using Azure;
using System.Data.SqlClient;
using System.Diagnostics;

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
            ///////////////////////////////
            SearchComboBox.Items.Clear();
            SearchComboBox.Items.Add("Show all");
            //////////////////////////////////

            String connectionString = "Server = DESKTOP-JOHN; Database = CMPT_291_FinalProject; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
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
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            // Show all cars after adding one
            ShowAllCars();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            String SelectedID = CarIDTextBox.Text;
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
            ShowAllCars();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            // if selection is "Show all" call ShowAllCars()
            if (SearchComboBox.Text == "Show all")
            {
                ShowAllCars();
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

    }
}