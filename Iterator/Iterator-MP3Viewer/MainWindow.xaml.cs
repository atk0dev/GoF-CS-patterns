using Iterator_MP3Library;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Iterator_MP3Viewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            OutputListBox.Items.Clear();

            var mp3s = new MP3Locator(@"D:\Users\jeremy\Music\iTunes\iTunes Music");
            foreach (var mp3 in mp3s
                .Where(m => m.Name.Contains(SearchTextBox.Text) ||
                            m.Directory.Name.Contains(SearchTextBox.Text) ||
                            m.Directory.Parent.Name.Contains(SearchTextBox.Text)))
            {
                OutputListBox.Items.Add(mp3);
            }
        }

        private void OutputListBox_MouseDoubleClick(object sender, 
            MouseButtonEventArgs e)
        {
            var selectedItem = OutputListBox.SelectedItem as FileInfo;
            if (selectedItem != null)
            {
                var mediaPlayer = "wmplayer.exe";

                var processInfo = new ProcessStartInfo();
                processInfo.FileName = mediaPlayer;
                processInfo.Arguments = string.Format("\"{0}\"", selectedItem.FullName);
                Process.Start(processInfo);
            }
        }
    }
}
