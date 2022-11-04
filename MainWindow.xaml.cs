using Library.Common;
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

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void listMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (listMenu.SelectedIndex)
            {
                case 0: MainFrame.Navigate(new Views.JournalPage()); break;
                case 1: MainFrame.Navigate(new Views.BooksPage()); break;
                case 2: MainFrame.Navigate(new Views.ReaderPage()); break;
                default:
                    break;
            }
        }
    }
}
