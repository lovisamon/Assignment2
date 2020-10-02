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
    /// Interaction logic for CurrentMessageViewModel.xaml
    /// </summary>
    public partial class CurrentMessageViewModel : UserControl
    {
        public CurrentMessageViewModel()
        {
            InitializeComponent();
        }
        public CurrentMessageViewModel(string sender, string title, string messageContent)
        {
            InitializeComponent();
            tbSender.Text = sender;
            tbTitle.Text = title;
            tbMessageContent.Text = messageContent;
        }
    }
}
