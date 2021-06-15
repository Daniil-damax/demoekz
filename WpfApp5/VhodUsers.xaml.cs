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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для VhodUsers.xaml
    /// </summary>
    public partial class VhodUsers : Page
    {
        MainWindow mw;
        public VhodUsers(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginVhodUsers.Text;
            string pass = PassVhodUsers.Text;
            int s=Class1.VhodUsers(login, pass);
            if (s != -1)
            {
                LKUser lk = new LKUser(s);
                lk.Show();
            }
            else
            {
                MessageBox.Show("net");
            }
        }
    }
}
