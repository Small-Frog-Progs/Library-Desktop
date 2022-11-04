using Library.Models;
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

namespace Library.Views
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage(Book book)
        {
            InitializeComponent();

            if (book.is_digit == 0)
            {
                btnDownload.IsEnabled = false;
            }
            this.DataContext = book;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.nainFrame.Navigate(new BooksPage());
        }
    }
}
