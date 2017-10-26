using Microsoft.Practices.Prism.Events;
using System.Collections.Generic;
using System.Windows;

namespace Observer_StockTicker
{
    public partial class App : Application
    {
        private List<Window> receivers = new List<Window>();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var eventAggregator = new EventAggregator();
            var generator = new StockGenerator(eventAggregator);
            var receiver1 = new StockReceiver(eventAggregator);
            var receiver2 = new StockReceiver(eventAggregator, "ABC");
            var receiver3 = new StockReceiver(eventAggregator, "XYZ");

            Application.Current.MainWindow = generator;

            generator.Show();
            receiver1.Top = 100;
            receiver1.Owner = generator;
            receiver1.Show();
            receiver2.Owner = generator;
            receiver2.Top = 300;
            receiver2.Show();
            receiver3.Owner = generator;
            receiver3.Top = 500;
            receiver3.Show();
        }
    }
}
