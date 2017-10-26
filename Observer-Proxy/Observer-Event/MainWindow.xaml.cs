using System.Windows;

namespace Observer_Event
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClickMeButton.Click += Observer1;
            ClickMeButton.Click += Observer2;
            ClickMeButton.Click += Observer3;
        }

        void Observer1(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = "Hello from Observer 1";
        }

        void Observer2(object sender, RoutedEventArgs e)
        {
            TextBlock2.Text = "Hello from Observer 2";
        }

        void Observer3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, from Observer 3");
        }
    }
}
