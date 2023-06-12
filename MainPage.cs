using Azure;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace CMPT291_Final_Project
{
    public partial class MainPage : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public MainPage()
        {
            InitializeComponent();

            String connectionString = "Server = DESKTOP-733UFP1; Database = CMPT_291_FinalProject; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds


            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection

                //Making a datatable to store start branch
                myCommand.CommandText = "SELECT City, BranchID FROM dbo.Branch";
                myReader = myCommand.ExecuteReader();

                DataTable dataTable1 = new DataTable();
                dataTable1.Load(myReader);

                myReader.Close();

                //Making a datatable to store end branch
                myCommand.CommandText = "SELECT City, BranchID FROM dbo.Branch";
                myReader = myCommand.ExecuteReader();

                DataTable dataTable2 = new DataTable();
                dataTable2.Load(myReader);

                myReader.Close();

                //Bind Rental Start location combobox
                StartBranchComboBox.DisplayMember = "City";
                StartBranchComboBox.ValueMember = "BranchID";
                StartBranchComboBox.DataSource = dataTable1;

                //Bind Rental End location combobox
                EndBranchComboBox.DisplayMember = "City";
                EndBranchComboBox.ValueMember = "BranchID";
                EndBranchComboBox.DataSource = dataTable2;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            SearchComboBox.DataSource = new List<String> {
                "Show All", "Car ID", "Make", "Model",
                "Year", "Mileage", "Registration",
                "License Plate", "CTID"
            };

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "insert into Car values (" + CarIDTextBox.Text + ",'" + MakeTextBox.Text + "','" + ModelTextBox.Text + "'," + YearTextBox.Text +
                                         "," + MileageTextBox.Text + ",'" + RegistrationTextBox.Text + "','" + LicensePlateTextBox.Text + "','" + CTIDTextBox.Text + "')";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
                myCommand.Dispose();
                // Show all cars after adding one
                ShowAllCars();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }


        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String SelectedID = CarIDTextBox.Text;

                // Don't modify on empty selection
                if (SelectedID == "") return;

                myCommand.CommandText = $"SELECT * FROM Car WHERE CarID = {SelectedID}";
                SqlDataReader Data = myCommand.ExecuteReader();

                if (Data.Read())
                {
                    String Changes = (
                        $"Please confirm these changes for Car ID {CarIDTextBox.Text} (Old -> New):\n\n" +
                        $"Make: {Data["Make"]} -> {MakeTextBox.Text}\n" +
                        $"Model: {Data["Model"]} -> {ModelTextBox.Text}\n" +
                        $"Year: {Data["Year"]} -> {YearTextBox.Text}\n" +
                        $"Mileage: {Data["Mileage"]} -> {MileageTextBox.Text}\n" +
                        $"Registration: {Data["Registration"]} -> {RegistrationTextBox.Text}\n" +
                        $"License Plate: {Data["LicensePlate"]} -> {LicensePlateTextBox.Text}\n" +
                        $"CTID: {Data["CTID"]} -> {CTIDTextBox.Text}"
                    );

                    DialogResult ConfirmModification = MessageBox.Show(
                    Changes, "Confirmation", MessageBoxButtons.YesNo
                    );

                    Data.Close();

                    if (ConfirmModification == DialogResult.Yes)
                    {
                        // Modify row
                        myCommand.CommandText = (
                            $"UPDATE Car " +
                            $"SET Make = '{MakeTextBox.Text}', " +
                            $"Model = '{ModelTextBox.Text}', " +
                            $"Year = {YearTextBox.Text}, " +
                            $"Mileage = {MileageTextBox.Text}, " +
                            $"Registration = '{RegistrationTextBox.Text}', " +
                            $"LicensePlate = '{LicensePlateTextBox.Text}', " +
                            $"CTID = '{CTIDTextBox.Text}' " +
                            $"WHERE CarID = {SelectedID};"
                        );
                        myCommand.ExecuteNonQuery();
                        myCommand.Dispose();
                    }
                }
                else Data.Close();

                ShowAllCars();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // if selection is "Show all" call ShowAllCars()
                if (SearchComboBox.Text == "Show All")
                {
                    ShowAllCars();
                }
                else
                {
                    myCommand.CommandText = $"SELECT * FROM Car WHERE " +
                        $"{SearchComboBox.Text.Replace(" ", "")} LIKE '{SearchTextBox.Text}%';";
                    myReader = myCommand.ExecuteReader();

                    Car.Rows.Clear();
                    while (myReader.Read())
                    {
                        Car.Rows.Add(myReader["CarID"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(), myReader["Year"].ToString(),
                        myReader["Mileage"].ToString(), myReader["Registration"].ToString(), myReader["LicensePlate"].ToString(), myReader["CTID"].ToString());
                    }

                    myReader.Close();
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsSelected = Car.Rows.GetRowCount(DataGridViewElementStates.Selected);
                String SelectedCars = "";
                for (int i = 0; i < RowsSelected; i++)
                {
                    SelectedCars += Car.SelectedRows[i].Cells["CarID"].Value;
                    if (i != RowsSelected - 1) SelectedCars += ", ";
                }

                DialogResult ConfirmDeletion = MessageBox.Show(
                    $"Confirm deletion of these cars: {SelectedCars}", "Confirmation",
                    MessageBoxButtons.YesNo
                );

                if (ConfirmDeletion == DialogResult.Yes)
                {
                    myCommand.CommandText = $"DELETE FROM Car WHERE CarID IN ({SelectedCars})";
                    MessageBox.Show($"Query used: {myCommand.CommandText}", "Debugging");
                    myCommand.ExecuteNonQuery();
                    myCommand.Dispose();
                }
                ShowAllCars();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void ShowAllCars()
        {
            myCommand.CommandText = "select * from Car";
            try
            {
                MessageBox.Show($"Query used: {myCommand.CommandText}");
                myReader = myCommand.ExecuteReader();

                Car.Rows.Clear();
                while (myReader.Read())
                {
                    Car.Rows.Add(myReader["CarID"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(), myReader["Year"].ToString(),
                    myReader["Mileage"].ToString(), myReader["Registration"].ToString(), myReader["LicensePlate"].ToString(), myReader["CTID"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void reportsbutton_Click(object sender, EventArgs e)
        {
            if (reportcombobox.SelectedItem != null)
            {
                ReportsLabel.Visible = true;
                ResultsDataGrid.Visible = true;


                if (reportcombobox.SelectedItem.ToString() == "Names customers who have not rented any cars with a daily price greater than 100 in the city of Edmonton.")
                {
                    myCommand.CommandText = "SELECT Customer.FirstName, Customer.LastName FROM Customer WHERE Customer.CustomerID IN (SELECT DISTINCT C1.CustomerID FROM Customer C1, Branch B1   WHERE C1.City = B1.City   AND C1.City = 'Edmonton'  AND NOT EXISTS ( SELECT R.CustomerID FROM Rental R, Car CA, CarType CT WHERE R.CarID = CA.CarID AND CA.CTID = CT.CTID AND CT.DailyPrice > 100 AND R.CustomerID = C1.CustomerID))";


                    ResultsDataGrid.ColumnCount = 2;
                    ResultsDataGrid.Columns[0].Name = "FirstName";
                    ResultsDataGrid.Columns[1].Name = "LastName";

                    ResultsDataGrid.ColumnHeadersVisible = true;



                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        ResultsDataGrid.Rows.Clear();

                        while (myReader.Read())
                        {
                            ResultsDataGrid.Rows.Add(myReader["FirstName"].ToString(), myReader["LastName"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }

                }
                else if (reportcombobox.SelectedItem.ToString() == "Finds the total rental branches in the City")
                {
                    myCommand.CommandText = "SELECT c.City, COUNT(*) AS TotalRentals FROM ( SELECT r.CustomerID, b.City FROM Rental r, Branch b   WHERE r.BranchIDIn = b.BranchID) AS c GROUP BY c.City";


                    ResultsDataGrid.ColumnCount = 2;
                    ResultsDataGrid.Columns[0].Name = "City";
                    ResultsDataGrid.Columns[1].Name = "TotalRentals";


                    ResultsDataGrid.ColumnHeadersVisible = true;


                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        ResultsDataGrid.Rows.Clear();

                        while (myReader.Read())
                        {
                            ResultsDataGrid.Rows.Add(myReader["City"].ToString(), myReader["TotalRentals"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }


                }
                else if (reportcombobox.SelectedItem.ToString() == "Customers rented in more than one branches in in different cities")
                {
                    myCommand.CommandText = "SELECT c.CustomerID, c.FirstName, c.LastName FROM Customer c WHERE c.CustomerID IN ( SELECT r.CustomerID FROM Rental r, Branch b  WHERE r.BranchIDIn = b.BranchID GROUP BY r.CustomerID HAVING COUNT(DISTINCT b.City) > 1)";


                    ResultsDataGrid.ColumnCount = 3;
                    ResultsDataGrid.Columns[0].Name = "CustomerID";
                    ResultsDataGrid.Columns[1].Name = "FirstName";
                    ResultsDataGrid.Columns[2].Name = "LastName";



                    ResultsDataGrid.ColumnHeadersVisible = true;



                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        ResultsDataGrid.Rows.Clear();

                        while (myReader.Read())
                        {
                            ResultsDataGrid.Rows.Add(myReader["CustomerID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }


                }
                else if (reportcombobox.SelectedItem.ToString() == "Branches that have cars with low mileage (less than 100000) and low prices (less than 100 a day)")
                {
                    myCommand.CommandText = "SELECT b.BranchID, b.City, b.Street, b.Postal FROM Branch b WHERE EXISTS ( SELECT * FROM Car c WHERE c.BranchID = b.BranchID AND c.Mileage < 5000 AND c.CTID IN ( SELECT CTID FROM CarType WHERE DailyPrice < 100 ))";


                    ResultsDataGrid.ColumnCount = 4;
                    ResultsDataGrid.Columns[0].Name = "BranchID";
                    ResultsDataGrid.Columns[1].Name = "City";
                    ResultsDataGrid.Columns[2].Name = "Street";
                    ResultsDataGrid.Columns[3].Name = "Postal";


                    ResultsDataGrid.ColumnHeadersVisible = true;


                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        ResultsDataGrid.Rows.Clear();

                        while (myReader.Read())
                        {
                            ResultsDataGrid.Rows.Add(myReader["BranchID"].ToString(), myReader["City"].ToString(), myReader["Street"].ToString(), myReader["Postal"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }


                }
                else if (reportcombobox.SelectedItem.ToString() == "Highest Daily Price of Car Make and Model from each branches")
                {
                    myCommand.CommandText = "SELECT C.BranchID, C.Make, C.Model, C.Year FROM Car C WHERE C.CTID IN (SELECT CTID FROM CarType CT WHERE CT.DailyPrice IN (SELECT MAX(DailyPrice) FROM CarType CT2 WHERE CT2.CTID = C.CTID))"
    ;


                    ResultsDataGrid.ColumnCount = 4;
                    ResultsDataGrid.Columns[0].Name = "BranchID";
                    ResultsDataGrid.Columns[1].Name = "Make";
                    ResultsDataGrid.Columns[2].Name = "Model";
                    ResultsDataGrid.Columns[3].Name = "Year";

                    ResultsDataGrid.ColumnHeadersVisible = true;


                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        ResultsDataGrid.Rows.Clear();

                        while (myReader.Read())
                        {
                            ResultsDataGrid.Rows.Add(myReader["BranchID"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(), myReader["Year"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }


            }
            else
            {
                MessageBox.Show("PLEASE SELECT A REPORT.", "Error");
            }
        }

        private void CheckAvailBtn_Click(object sender, EventArgs e)
        {
            // Rental data grid
            DataGridView rental = dataGridView1;

            DateTimePicker startDate = dateTimePicker2;
            DateTimePicker endDate = dateTimePicker1;

            String startDateString = startDate.Value.ToString("yyyy-MM-dd");
            String endDateString = endDate.Value.ToString("yyyy-MM-dd");

            // Renting # of days
            int daysRented = (endDate.Value - startDate.Value).Days;

            // Error check end date >= start date
            if (DateTime.Compare(startDate.Value, endDate.Value) >= 0)
            {
                MessageBox.Show(
                    $"Ensure that \"Start Date\" is EARLIER than \"End Date\"\n\n" +
                    $"Current Start date is: {startDate.Value.ToString("MMMM dd, yyyy")}\n" +
                    $"Current End date is: {endDate.Value.ToString("MMMM dd, yyyy")}",
                    "Error"
                    );
                return;
            }

            // Select car IDs that are available
            myCommand.CommandText = (
                $"SELECT CarID, Make, Model, Year, CTID FROM dbo.Car WHERE CarID IN (\n" +
                $"SELECT CarID FROM dbo.CAR WHERE CarID NOT IN (\n" +
                $"SELECT CarID FROM dbo.Rental\n" +
                $")\n" +
                $"UNION\n" +
                $"SELECT CarID FROM dbo.Rental WHERE CarID NOT IN (\n" +
                $"SELECT CarID FROM dbo.Rental WHERE\n" +
                $"(DateFrom > '{startDateString}' AND DateTo < '{endDateString}') OR\n" +
                $"(DateTo > '{startDateString}' AND DateFrom < '{endDateString}')\n" +
                $")\n" +
                $")"
            );
            myReader = myCommand.ExecuteReader();

            rental.Rows.Clear();
            while (myReader.Read())
            {
                rental.Rows.Add(
                    myReader["CarID"].ToString(),
                    myReader["Make"].ToString(),
                    myReader["Model"].ToString(),
                    myReader["Year"].ToString()
                );
            }
            myReader.Close();

            foreach (DataGridViewRow row in rental.Rows)
            {
                myCommand.CommandText = (
                    $"SELECT DailyPrice, WeeklyPrice, MonthlyPrice FROM (\n" +
                    $"SELECT CarID, CTID FROM dbo.Car WHERE CarID = {row.Cells[0].Value})\n" +
                    $"AS T1, dbo.CarType WHERE T1.CTID = CarType.CTID"
                );
                myReader = myCommand.ExecuteReader();
                myReader.Read();

                int dailyPrice = int.Parse(myReader["DailyPrice"].ToString()!);
                int weeklyPrice = int.Parse(myReader["WeeklyPrice"].ToString()!);
                int monthlyPrice = int.Parse(myReader["MonthlyPrice"].ToString()!);

                int dayCalculation = daysRented;

                int numWeeks = (int)Math.Floor(dayCalculation / 7.0);
                dayCalculation -= numWeeks * 7;

                int numMonths = (int)Math.Floor(numWeeks / 4.0);
                numWeeks -= numMonths * 4;

                int totalPrice = (dayCalculation * dailyPrice) +
                                 (numWeeks * weeklyPrice) +
                                 (numMonths * monthlyPrice);

                row.Cells[4].Value = totalPrice;

                myReader.Close();
            }
        }

        private void CreateRentalButton_Click(object sender, EventArgs e)
        {
            string StartCity = StartBranchComboBox.Text;
            string EndCity = EndBranchComboBox.Text;
            MessageBox.Show("Starting Branch: " + StartCity + "BranchID: " + StartBranchComboBox.SelectedValue +
                            "\nEnd Branch: " + EndCity + "BranchID: " + StartBranchComboBox.SelectedValue ,
                            "Rental confirmation");
        }
    }
}
