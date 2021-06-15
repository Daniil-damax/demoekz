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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для LkAdmin.xaml
    /// </summary>
    public partial class LkAdmin : Window
    {
        public LkAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameLkAdmin.Navigate(new CreateAdmin());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameLkAdmin.Navigate(new ListAdmins());
        }
    }
}
