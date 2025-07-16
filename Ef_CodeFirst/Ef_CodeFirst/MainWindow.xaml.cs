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

namespace Ef_CodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SchoolContext db = new SchoolContext();
        public MainWindow()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {
            grdStudents.ItemsSource = db.Students.ToList();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            //Get Entered Id
            int id =int.Parse( txtId.Text);
            //Find Student With 

            Student studentFound = db.Students.Find(id);
            if (studentFound != null) {
                //Display std data
                txtName.Text = studentFound.StudentName;
                cmbStandard.SelectedIndex = (int)studentFound.StandardId - 1;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var standards = db.Standards.ToList();

            cmbStandard.ItemsSource = standards;
            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardId";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id=int.Parse( txtId.Text);
            Student studentFound = db.Students.Find(id);
            if (studentFound != null)
            {
                studentFound.StudentName = txtName.Text;
                studentFound.StandardId = cmbStandard.SelectedIndex+1;
                MessageBox.Show("Student Info Updated");

            }
            else
            {
                MessageBox.Show("Student not found");

            }
            db.SaveChanges();
            RefreshDataGrid();

        }
    }
}