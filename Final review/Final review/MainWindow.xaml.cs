using System;
using System.Linq;
using System.Windows;

namespace Final_review
{
    public partial class MainWindow : Window
    {
        SchoolDBEntities db = new SchoolDBEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var students = db.Students.ToList();
                grdStudents.ItemsSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var standards = db.Standards.ToList();
                cmbStandard.ItemsSource = standards;
                cmbStandard.DisplayMemberPath = "StandardName";
                cmbStandard.SelectedValuePath = "StandardId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading standards: " + ex.Message);
            }
        }
    }
}
