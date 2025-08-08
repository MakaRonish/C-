using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DisconnectedModelExample
{
    /// <summary>
    /// Interaction logic for DataSetWithMultipleTables.xaml
    /// </summary>
    public partial class DataSetWithMultipleTables : Window
    {

        //get connection string from app.config file
        string connStr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable tblProducts;
        DataTable tblCategories;


        public DataSetWithMultipleTables()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                conn= new SqlConnection(connStr);
                string query = "Select * from Products;Select * from categories";
                adapter = new SqlDataAdapter(query,conn);
                ds = new DataSet();   //EMpty data set
                adapter.Fill(ds);

                tblProducts = ds.Tables[0];
                tblCategories = ds.Tables[1];
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            grdProducts.ItemsSource = tblProducts.DefaultView;
            grdCateories.ItemsSource = tblCategories.DefaultView;
        }
    }
}
