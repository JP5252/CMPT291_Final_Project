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

            String connectionString = "Server = DESKTOP-733UFP1; Database = CMPT_291_FinalProject; Trusted_Connection = yes;";

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
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Car";

            try
            {
                MessageBox.Show(myCommand.CommandText);
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