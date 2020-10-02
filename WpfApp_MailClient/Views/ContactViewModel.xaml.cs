using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_MailClient.Views
{
    /// <summary>
    /// Interaction logic for ContactViewModel.xaml
    /// </summary>
    public partial class ContactViewModel : UserControl
    {
        public static Grid ctrl;
        public ContactViewModel()
        {
            InitializeComponent();
            ctrl = this.FindName("userControlCurrentContact") as Grid;

            ContactList.Children.Add(new Controls.ContactControl() { ContactName = "Me", ContactEmail = "lovisa@hotmail.com" });
            ContactList.Children.Add(new Controls.ContactControl() { ContactName = "Stina Eriksson", ContactEmail = "stina@hotmail.com" });
            ContactList.Children.Add(new Controls.ContactControl() { ContactName = "Elena Ivanov", ContactEmail = "elena@hotmail.com" });
            ContactList.Children.Add(new Controls.ContactControl() { ContactName = "Alejandro Garcia", ContactEmail = "alejandro@hotmail.com" });
        }
    }
}
