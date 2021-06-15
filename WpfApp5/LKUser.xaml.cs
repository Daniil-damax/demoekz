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
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для LKUser.xaml
    /// </summary>
    public partial class LKUser : Window
    {
        public int id;
        public LKUser(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Class1.FillDataGrid(LKUserDataGrid);
        }
    }
}
