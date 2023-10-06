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

namespace yshot_bydjeta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> boxxes = new List<string> { "Еда", "Игры", "Развлечения", "Степуха" };
        public string type_cheng;
        public MainWindow()
        {
            InitializeComponent();
            PickData.Text = DateTime.Now.ToString();
            logica.log(this);
            typecombobox.ItemsSource = boxxes;
        }

        private void add_new_type(object sender, RoutedEventArgs e)
        {
            Window1 tip = new Window1();
            bool? t = tip.ShowDialog();
            typecombobox.ItemsSource = "";
            if (tip.res == true)
            {
                string a = tip.new_type_win;
                boxxes.Add(a);

            }
            else if (tip.res == false)
            {
                MessageBox.Show("Вы закрыли окно неправильно!");
            }
            typecombobox.ItemsSource = boxxes;
        }

        private void add(object sender, RoutedEventArgs e)
        {
            logica.add(this);
        }

        private void edit(object sender, RoutedEventArgs e)
        {
            logica.edit(this);
        }

        private void del(object sender, RoutedEventArgs e)
        {
            logica.log(this);
        }

        private void PickData_CalendarClosed(object sender, RoutedEventArgs e)
        {
            logica.log(this);
        }

        private void typecombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                type_cheng = boxxes[typecombobox.SelectedIndex];
            }
            catch
            {
                typecombobox.SelectedItem = "";
            }
        }
    }
}
