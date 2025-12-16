using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Event
{
    public class ChartEvent
    {
        public void Subscribe(StockTickerEvent ticker)
        {
            ticker.PriceChanged += Update;
        }

        private void Update(string stock, double price)
        {
            Console.WriteLine($"[ChartEvent] Обновление графика: {stock} = {price}");
        }
    }
}
