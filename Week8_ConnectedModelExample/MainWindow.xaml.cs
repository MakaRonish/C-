using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week8_ConnectedModelExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Get the connection string 

        String connStr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            //1)Create object of Connection class
            SqlConnection conn = new SqlConnection(connStr);

            String query = "Select EmployeeID,FirstName,LastName,Title from Employees";

            //2)Create object of command class

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            //3) Call ExecuteReader() that will return DataReader Object here
            SqlDataReader data = cmd.ExecuteReader();

            //4)New Table and load the data from data reader Object
            DataTable empTable = new DataTable();

            empTable.Load(data);

            //5)Display data in the dataGrid
            grdEmployees.ItemsSource = empTable.DefaultView;

            conn.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "Select Count(*) from Employees";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                int rows = (int)cmd.ExecuteScalar();
                MessageBox.Show("Total Rows in Employee table= " + rows);
            }

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Get the entered value

            String EnteredFirstName = txtFirstname.Text;

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                string query = "Select * from Employees where FirstName=@FirstName";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("FirstName", EnteredFirstName);
                conn.Open();

                SqlDataReader data = cmd.ExecuteReader();

                DataTable empTable = new DataTable();
                empTable.Load(data);

                if (empTable.Rows.Count > 0)
                {
                    grdEmployees.ItemsSource = empTable.DefaultView;
                }
                else
                {
                    MessageBox.Show("No Employee found with given name");
                }




            }



        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            String enteredFirstName = txtFirstname.Text;
            String enteredLastName = txtLastname.Text;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "Insert into Employees(FirstName,LastName) values(@FirstName,@LastName) ";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Give values for @FirstName and @LastName  parameters

                cmd.Parameters.AddWithValue("FirstName", enteredFirstName);
                cmd.Parameters.AddWithValue("LastName", enteredLastName);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Row Inserted");
                    LoadData();     //Refresh Data Grid 
                }
                else
                {
                    MessageBox.Show("Error:Not inserted");
                }
            }
        }

    }
}