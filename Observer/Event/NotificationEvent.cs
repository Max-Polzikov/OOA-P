using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Event
{
    public class NotificationEvent
    {
        public void Subscribe(StockTickerEvent ticker)
        {
            ticker._priceChanged += Update;
        }

        private void Update(string stock, double price)
        {
            Console.WriteLine($"[NotificationEvent] Уведомление: {stock} теперь стоит {price}");
        }
    }
}
