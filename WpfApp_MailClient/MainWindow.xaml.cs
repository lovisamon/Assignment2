using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_MailClient.Models;

namespace WpfApp_MailClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMessages_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MessageModel();
        }

        private void btnContacts_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModel();
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CalendarModel();
        }

        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TaskModel();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SettingsModel();
        }
    }
}
