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
    /// Логика взаимодействия для RegUser.xaml
    /// </summary>
    public partial class RegUser : Page
    {
        public RegUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginRegUser.Text;
            string pass = PassRegUser.Text;
            string fio = FioRegUser.Text;
            string email = EmailRegUser.Text;
            string tel = TelRegUser.Text;
            string birthday = BirthdayRegUser.Text;

            bool s= Class1.RegUsers(login, pass, fio, email, tel, birthday);
            if (s == true)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("net");
            }
        }
    }
}
