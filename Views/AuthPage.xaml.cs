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
using Library.Controls;

namespace Library.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbEmail.Text)||String.IsNullOrEmpty(tbPassword.Password))
            {
                MessageBox.Show("Не корректно введены данные!");
                return;
            }
            Authorization authorization = new Authorization();
            string resultSiganture = authorization.SignIn(tbEmail.Text, tbPassword.Password);
            if (resultSiganture=="error")
            {
                MessageBox.Show("Неверные данные пользователя!");
                return;
            }

            MessageBox.Show(resultSiganture);



        }
    }
}
