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
using WpfApp_MailClient.Models;
using WpfApp_MailClient.Views;

namespace WpfApp_MailClient.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        public string ContactName
        {
            get { return tbContactName.Text; }
            set { tbContactName.Text = value; }
        }

        public string ContactEmail
        {
            get { return tbContactEmail.Text; }
            set { tbContactEmail.Text = value; }
        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            TextBlock tbContactName = btn.FindName("tbContactName") as TextBlock;
            TextBlock tbContactEmail = btn.FindName("tbContactEmail") as TextBlock;

            DataContext = new CurrentContactModel();

            CurrentContactViewModel ctrl = new CurrentContactViewModel(tbContactName.Text, tbContactEmail.Text);

            ContactViewModel.ctrl.Children.Add(ctrl);
        }
    }
}
