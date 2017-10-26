using Microsoft.Practices.Prism.Events;

namespace Observer_StockTicker
{
    public class StockTickerEvent : CompositePresentationEvent<StockTickerPayload>
    {
    }

    public class StockTickerPayload
    {
        public string StockId { get; set; }
        public float StockValue { get; set; }
    }
}
