﻿using System;
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
    /// Логика взаимодействия для CreateAdmin.xaml
    /// </summary>
    public partial class CreateAdmin : Page
    {
        public CreateAdmin()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginCreateAdminTextBox.Text;
            string pass = PassCreateAdminTextBox.Text;
            Class1.CreateAdmin(login, pass);
        }
    }
}
