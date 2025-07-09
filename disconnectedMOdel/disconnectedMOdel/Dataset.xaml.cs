using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using Microsoft.Data.SqlClient;

namespace disconnectedMOdel
{
    /// <summary>
    /// Interaction logic for Dataset.xaml
    /// </summary>
    public partial class Dataset : Window
    {
        //string connStr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        string connstr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        public Dataset()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection conn = new SqlConnection(connstr);

            string query = "SELECT * FROM Categories; SELECT * FROM Products";


            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            DataTable tblCategories = ds.Tables[0];
            DataTable tblProducts = ds.Tables[1];


            grdCategories.ItemsSource = tblCategories.DefaultView;
            grdProduct.ItemsSource = tblProducts.DefaultView;


        }
    }
}
