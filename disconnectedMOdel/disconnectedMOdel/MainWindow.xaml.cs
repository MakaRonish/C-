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
using Microsoft.Data.SqlClient;

namespace disconnectedMOdel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //conection string

        string connStr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        public MainWindow()
        {
            InitializeComponent();
        }
        public DataTable LoadData()
        {
            //sql connection (app.config)
            SqlConnection conn= new SqlConnection(connStr);
            string query = "Select productID,ProductName, UnitPrice, UnitsInStock from products";


            //sqldata adapter
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);


            //Dataset
            DataSet ds= new DataSet();
            adapter.Fill(ds);

            //datatable
            DataTable tblProduct= ds.Tables[0];

            //define primary key
            DataColumn[] pk = new DataColumn[1];
            pk[0] = tblProduct.Columns["productID"];
            pk[0].AutoIncrement = true;
            tblProduct.PrimaryKey = pk;
            
            return tblProduct;
        }
        public DataRow GetProductById(int id)
        {
            DataTable tblProducts = LoadData();

            DataRow row = tblProducts.Rows.Find(id);
            return row;
        }
    

        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
           DataTable tblProducts= LoadData();
            

            grdProducts.ItemsSource = tblProducts.DefaultView;

        }

        private void btnShowWindow2_Click(object sender, RoutedEventArgs e)
        {
            Dataset window2 = new Dataset();
            window2.Show();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            DataRow row= GetProductById(id);
            if (row != null)
            {
                txtName.Text = row["ProductName"].ToString();
                txtPrice.Text= row["UnitPrice"].ToString() ;
                txtQuantity.Text = row["UnitsInStock"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Product id");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            //create a new row
            DataTable tableProducts = LoadData();
            DataRow row = tableProducts.NewRow();.


            //assign values to row get from textbox
            row["ProductName"] = txtName.Text;
            //Add row to table
        }
    }
}