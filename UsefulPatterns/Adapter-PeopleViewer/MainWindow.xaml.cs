using PersonRepository.Interface;
using PersonRepository.SQL;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        private IPersonRepository repository;

        public MainWindow()
        {
            InitializeComponent();
            repository = new SQLRepository();
        }

        private void FetchDataButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            var people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
        }
    }
}
