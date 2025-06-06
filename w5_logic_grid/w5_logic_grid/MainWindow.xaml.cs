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

namespace w5_logic_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string Username = "Ronish";
        string Password = "Password";

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            string log_user= txb_user.Text;
            string log_pass= txb_pass.Text;

            if (log_user == Username && log_pass == Password) {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("INvalid");
            }
        }
    }
}