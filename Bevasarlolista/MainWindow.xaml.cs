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

namespace Bevasarlolista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lkjvds = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            listbox.ItemsSource = lkjvds;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            lkjvds.Add(textbox.Text);
            listbox.Items.Refresh();
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lkjvds.Add(textbox.Text);
                listbox.Items.Refresh();
            }
        }
    }
}