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

namespace W5_1_WPF_basic
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
        static int click = 0;

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            click++;

            lb1_Name.Content = $"You clicked {click} times";
            lb1_Name.Background = Brushes.Green;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            click = 0;
            lb1_Name.Content = $"You clicked {click} times";
        }
    }
}