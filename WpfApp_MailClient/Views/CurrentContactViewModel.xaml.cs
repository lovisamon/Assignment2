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
    /// Interaction logic for CurrentContactViewModel.xaml
    /// </summary>
    public partial class CurrentContactViewModel : UserControl
    {
        public CurrentContactViewModel()
        {
            InitializeComponent();
        }
        public CurrentContactViewModel(string contactName, string contactEmail)
        {
            InitializeComponent();
            tbContactName.Text = contactName;
            tbContactEmail.Text = contactEmail;
        }
    }
}
