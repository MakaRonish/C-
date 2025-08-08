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

namespace DisconnectedModelExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //get connection string from app.config file
        string connStr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        //SqlConnnection(connStr)
        SqlConnection conn;

        //SqlDataAdapter
        SqlDataAdapter adapter;

        //SqlCommandBuilder

        SqlCommandBuilder builder;                            //Insert,update and delete

        //DataSet
        DataSet ds;

        //DataTable
        DataTable tblProducts;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            conn = new SqlConnection(connStr);

            string query = "Select ProductID,ProductName,UnitPrice,UnitsInStock from Products ";
            adapter = new SqlDataAdapter(query, conn);
            builder= new SqlCommandBuilder(adapter);

            DataSet ds= new DataSet();                      //Empty DataSet
            adapter.Fill(ds);                              //Fill data set

            tblProducts= ds.Tables[0];

            //DEfine Primary Key

            DataColumn[] pk = new DataColumn[1];       //create new DataColumn
            pk[0] = tblProducts.Columns["ProductID"];
            pk[0].AutoIncrement = true;
            tblProducts.PrimaryKey= pk;      //set Primary key for tblProducts

            RefreshGrid();
            
        }

        public void RefreshGrid()
        {
            //Display tblProduct in dataGrid (grdProducts)
            grdProducts.ItemsSource=tblProducts.DefaultView;
        }

        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            //Get Entered Id
            int id =int.Parse (txtId.Text);

            //Find row with given id

            DataRow  row=tblProducts.Rows.Find(id);


            //Display row values in textboxes
             
            if (row != null)
            { 
                txtName.Text = row["ProductName"].ToString();
                txtPrice.Text= row["UnitPrice"].ToString() ;
                txtQuantity.Text = row["UnitsInStock"].ToString();
            }
            else
            {
                MessageBox.Show("Row not found.Incorrect id.Please try again.");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            //Get entered values
            string name=txtName.Text;
            decimal  unitPrice= decimal.Parse(txtPrice.Text);
            short unitsInStock = short.Parse(txtQuantity.Text);

            //Create new row

            DataRow   newRow= tblProducts.NewRow();

            //ADd values to the row

            newRow["ProductName"] = name;
            newRow["UnitPrice"]= unitPrice;
            newRow["UnitsInStock"] = unitsInStock;

            //ADd row to tblProduct
            tblProducts.Rows.Add(newRow);

            //Execute Insert Command and update Database

            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.Update(tblProducts);

            LoadData();
            RefreshGrid();

            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Get entered id
            int id= int.Parse (txtId.Text);

            //Find row with given Id
            DataRow rowFound= tblProducts.Rows.Find(id);

            //Delete Row
            if(rowFound!=null)
            {
                  rowFound.Delete();
            }

            else
            {
                MessageBox.Show("Incorrect Id .Please try again.");
            }

            //Execute delete command and update database

            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(tblProducts);

            //Refresh grid
            LoadData(); RefreshGrid();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Get Id
            int id = int.Parse(txtId.Text);

            //Find row with given id
            DataRow rowFound= tblProducts.Rows.Find(id);

            //Get entered values(name,price,quantity)
            string name = txtName.Text;
            decimal price= decimal.Parse(txtPrice.Text);
            short quantity= short.Parse(txtQuantity.Text);

            //Update row values  only if row found 
            if (rowFound!=null)
            {
                rowFound["ProductName"] = name;
                rowFound["UnitPrice"]=price;
                rowFound["UnitsInStock"]=quantity;
            }else
            {
                MessageBox.Show("Incorrect id.Please try again");
            }

            //Execute Update command adn update  orgional database

            adapter.UpdateCommand= builder.GetUpdateCommand();
            adapter.Update(tblProducts);

            //Refresh Data Grid
            RefreshGrid();

            
        }

        private void btnShowWindow2_Click(object sender, RoutedEventArgs e)
        {
            //Display second window

            DataSetWithMultipleTables window2= new DataSetWithMultipleTables();
            window2.Show();
        }
    }
}