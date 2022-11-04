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
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();

            Controls.JournalController controller = new Controls.JournalController();
            listJournal.ItemsSource = controller.GetLogs();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbIdSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbIdBookSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbIdReaderSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
