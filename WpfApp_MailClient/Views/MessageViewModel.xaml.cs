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
    /// Interaction logic for MessageViewModel.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        public static Grid ctrl;
        public MessageViewModel()
        {
            InitializeComponent();
            ctrl = this.FindName("userControlCurrentMessage") as Grid;

            MessageList.Children.Add(new Controls.MessageControl() { Sender = "Lily Sanderson", Title = "Hello again!", MessageContent = "lorum ipsum...hi" });
            MessageList.Children.Add(new Controls.MessageControl() { Sender = "David Schwarz", Title = "Missed meeting", MessageContent = "lorum ipsum...sorry" });
        }
    }
}
