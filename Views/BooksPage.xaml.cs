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
    /// Логика взаимодействия для BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        Controls.BookController controller = new Controls.BookController();
        public BooksPage()
        {
            InitializeComponent();

            UpdateData();
        }
        private void UpdateData()
        {
            listBooks.ItemsSource = controller.GetBooks();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbIdSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbNameSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listBooks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameManager.nainFrame.Navigate(new BookPage((Book)listBooks.SelectedItem));
        }
    }
}
