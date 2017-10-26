using Proxy_ServiceProxy.MyService;
using System.Windows;

namespace Proxy_ServiceProxy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            PersonServiceClient serviceProxy = new PersonServiceClient();
            PersonListBox.ItemsSource = serviceProxy.GetPeople();
        }
    }
}
