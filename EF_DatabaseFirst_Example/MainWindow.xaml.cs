using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_DatabaseFirst_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Object of Context class

        Entities db= new Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            //Get student(table) data
            var students = db.Students.ToList();

            //Display in the datagrid
            grdStudents.ItemsSource= students;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Get data from standards table
            var standards=db.Standards.ToList();

            //Display in the combo box
            cmbStandard.ItemsSource= standards;
            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardID";
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            //Get entered id
            int id= int.Parse(txtId.Text);

            //Find student with given id
            Student studentFound=db.Students.Find(id);

            //Display student information in textbox(name and combo box(standard name)
            txtName.Text = studentFound.StudentName;

            cmbStandard.SelectedIndex = (int)studentFound.StandardId - 1;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Get entered name
            string name= txtName.Text;

            //Search student with given name:LINQ query

            var studentFound = (from s in db.Students
                               where s.StudentName == name
                               select s).FirstOrDefault();
            //If student found then display student data in message box

            if(studentFound!= null)
            {
                MessageBox.Show($"ID={studentFound.StudentID}\nName={studentFound.StudentName}\nStandard Name={studentFound.Standard.StandardName}");
            }
            else
            {
                MessageBox.Show("Student does not exist.Try different name.");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            //get entered name and selected standard
            string name= txtName.Text;
            int standardId = cmbStandard.SelectedIndex + 1;

            //create new student object
            Student newStudent = new Student();

            //set studentname and standard for new student 
            newStudent.StudentName = name;
            newStudent.StandardId = standardId;

            //Add student to Enitity set
            db.Students.Add(newStudent);

            //SaveChanges()
            db.SaveChanges();
        }
    }
}
