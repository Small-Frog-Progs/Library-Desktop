using Library.Common;
using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        private Book _book;
        public BookPage(Book book)
        {
            InitializeComponent();

            if (book.is_digit == 0)
            {
                btnDownload.IsEnabled = false;
            }
            this.DataContext = book;
            _book = book;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.nainFrame.Navigate(new BooksPage());
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists("books"))
            {
                Directory.CreateDirectory("books");
            }
            if (_book.book_path.ToString() != "")
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFileAsync(new Uri(ServerAddress.ImagePath+_book.book_path.ToString()), "books/" + _book.name + ".pdf");

                };
            }
        }
    }
}
