using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Observer_StockTicker
{
    public partial class StockGenerator : Window
    {
        private int _currentValue = 100;
        private IEventAggregator _eventAggregator;
        private Random _random;
        private List<string> _stockIds;

        public StockGenerator(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            _eventAggregator = eventAggregator;
            _random = new Random();
            _stockIds = new List<string>()
            {
                "ABC", "RUFF", "XYZ",
            };
            StockIdCombo.ItemsSource = _stockIds;
            StockIdCombo.SelectedIndex = 0;
        }

        private void GenerateOneButton_Click(object sender, RoutedEventArgs e)
        {
            GenerateTickerEvent();
        }

        private void GenerateOneHundredButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++ )
                GenerateTickerEvent();
        }

        private void GenerateTickerEvent()
        {
            var delta = _random.Next(-1, 2);
            var stockId = StockIdCombo.Text;
            _currentValue += delta;
            var output = string.Format("{0}: {1}", stockId, _currentValue.ToString());
            StockValueList.Items.Insert(0, output);

            var payload = new StockTickerPayload
            {
                StockId = stockId,
                StockValue = _currentValue,
            };
            _eventAggregator.GetEvent<StockTickerEvent>().Publish(payload);
        }

    }
}
