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
using System.Windows.Shapes;

namespace yshot_bydjeta
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string new_type_win;
        public bool res = false;
        public Window1()
        {
            InitializeComponent();
        }

        private void add_type_new(object sender, RoutedEventArgs e)
        {
            new_type_win = newtypetext.Text.ToString();
            res = true;
            Close();
        }
    }
}
