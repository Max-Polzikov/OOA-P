using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Event
{
    public class StockTickerEvent
    {
        public event Action<string, double> PriceChanged;

        public void SetPrice(string stock, double price)
        {
            PriceChanged?.Invoke(stock, price); 
        }
    }
}
