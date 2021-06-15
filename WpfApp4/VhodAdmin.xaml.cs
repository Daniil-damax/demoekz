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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для VhodAdmin.xaml
    /// </summary>
    public partial class VhodAdmin : Page
    {
        MainWindow mw;
        public VhodAdmin(MainWindow mw)
        {

            InitializeComponent();
            this.mw = mw;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginAdminTextBox.Text;
            string pass = PassAdminTextBox.Text;
            bool q= Class1.VhodAdmin(login, pass);
            if(q== true)
            {
                LkAdmin s = new LkAdmin();
                s.Show();
                mw.Close();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
