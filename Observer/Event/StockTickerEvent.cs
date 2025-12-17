using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Event
{
    public class StockTickerEvent
    {
        public event Action<string, double> _priceChanged;

        public void SetPrice(string stock, double price)
        {
            _priceChanged?.Invoke(stock, price); 
        }
    }
}
