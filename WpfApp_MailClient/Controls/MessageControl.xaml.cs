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
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public string Sender
        {
            get { return tbSender.Text; }
            set { tbSender.Text = value; }
        }
        public string Title
        {
            get { return tbTitle.Text; }
            set { tbTitle.Text = value; }
        }

        public string MessageContent
        {
            get { return tbMessageContent.Text; }
            set { tbMessageContent.Text = value; }
        }

        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            TextBlock tbSender = btn.FindName("tbSender") as TextBlock;
            TextBlock tbTitle = btn.FindName("tbTitle") as TextBlock;
            TextBlock tbMessageContent = btn.FindName("tbMessageContent") as TextBlock;

            DataContext = new CurrentMessageModel();

            CurrentMessageViewModel ctrl = new CurrentMessageViewModel(tbSender.Text, tbTitle.Text, tbMessageContent.Text);

            MessageViewModel.ctrl.Children.Add(ctrl);
        }
    }
}
