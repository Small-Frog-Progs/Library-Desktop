using Library.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для ReaderPage.xaml
    /// </summary>
    public partial class ReaderPage : Page
    {
        Controls.UserController controller = new Controls.UserController();
        List<User> users = new List<User>();
        IEnumerable<User> users1 = new List<User>();

        public ReaderPage()
        {
            InitializeComponent();

            UpdateData();
        }
        private void UpdateData()
        {
            users = controller.GetUsers();
            listReaders.ItemsSource = users;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller.DeleteUser(((User)listReaders.SelectedItem).id.ToString());
                UpdateData();
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? selectedDate = dpDateOfBirth.SelectedDate;

                controller.CreateUser(tbName.Text, tbEmail.Text, selectedDate.Value.Date.ToShortDateString(), "123");
                UpdateData();
            }
            catch (Exception)
            {
            }
        }

        private void tbNameSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchUser();
        }

        private void tbIdSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchUser();
        }
        private void SearchUser()
        {
            try
            {
                users1 = users;
                users1 = users.Where(x => x.id.ToString().Contains(tbIdSearch.Text));
                users1 = users.Where(x => x.name.ToLower().Contains(tbNameSearch.Text.ToLower()));
                listReaders.ItemsSource = users1;
            }
            catch (Exception)
            {

            }
        }
    }
}
