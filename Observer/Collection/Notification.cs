using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Collection
{
    public class Notification : IObserver
    {
        public void Update(string stock, double price)
        {
            Console.WriteLine($"[Notification] Уведомление: {stock} теперь стоит {price}");
        }
    }
}
