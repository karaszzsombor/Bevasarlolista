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
        public void add()
        {
            if(textbox.Text == "")
            {
                MessageBox.Show("hiba", "hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                lkjvds.Add(textbox.Text);
                listbox.Items.Refresh();
                textbox.Text = "";
                label.Content = lkjvds.Count().ToString();
            }
        }

        public void del()
        {
            if(listbox.SelectedItem == null)
            {
                MessageBox.Show("hiba", "hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                lkjvds.Remove(listbox.SelectedItem as string);
                listbox.Items.Refresh();
                label.Content = lkjvds.Count().ToString();
            }
        }
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            add();
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                add();
            }
        }

        private void listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Delete)
            {
                del();
            }
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            del();
        }

        private void Button_del_all_Click(object sender, RoutedEventArgs e)
        {
            if (lkjvds.Count() == 0)
            {
                MessageBox.Show("hiba", "hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                lkjvds.Clear();
                listbox.Items.Refresh();
                label.Content = lkjvds.Count().ToString();
            }

        }
    }
}