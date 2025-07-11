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
        DataTable tblProduct;
        SqlConnection conn;
        SqlDataAdapter adapter;
        Dataset ds;
        SqlCommandBuilder builder;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            //sql connection (app.config)
            conn= new SqlConnection(connStr);
            string query = "Select productID,ProductName, UnitPrice, UnitsInStock from products";


            //sqldata adapter
             adapter = new SqlDataAdapter(query,conn); 


            //CommandBuilder 
            builder = new SqlCommandBuilder(adapter);


            //Dataset
            DataSet ds= new DataSet();
            adapter.Fill(ds);

            //datatable
            tblProduct= ds.Tables[0];

            //define primary key
            DataColumn[] pk = new DataColumn[1];
            pk[0] = tblProduct.Columns["productID"];
            pk[0].AutoIncrement = true;
            tblProduct.PrimaryKey = pk;
            
           
        }

        public void RefreshDataGrid()
        {
            LoadData();
            grdProducts.ItemsSource = tblProduct.DefaultView;
        }
        public DataRow GetProductById(int id)
        {
            

            DataRow row = tblProduct.Rows.Find(id);
            return row;
        }
    

        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
           
            

            grdProducts.ItemsSource = tblProduct.DefaultView;

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
            
            DataRow row = tblProduct.NewRow();


            //assign values to row get from textbox
            row["ProductName"] = txtName.Text;
            row["UnitPrice"] = decimal.Parse(txtPrice.Text);
            row["UnitsInStock"] = short.Parse(txtQuantity.Text);
            
            //Add row to table
            tblProduct.Rows.Add(row);

            //execute insert
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.Update(tblProduct);
            RefreshDataGrid();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Get entered Id
            int id = int.Parse(txtId.Text);

            //find row where given id
            DataRow row = tblProduct.Rows.Find(id);
            if (row != null)
            {
                string name = txtName.Text;
                decimal price= decimal.Parse(txtPrice.Text);
                short unitsInStock=short.Parse(txtQuantity.Text);

                //update

                row["ProductName"] = name;
                row["UnitPrice"] = price;
                row["UnitsInStock"] = unitsInStock;


                //execute
                adapter.InsertCommand = builder.GetUpdateCommand();
                adapter.Update(tblProduct);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("INcorrect id");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);

            DataRow row= tblProduct.Rows.Find(id);

            row.Delete();

            adapter.InsertCommand = builder.GetDeleteCommand();
            adapter.Update(tblProduct);
            RefreshDataGrid();


        }
    }
}