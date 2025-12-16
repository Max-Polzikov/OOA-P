using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Collection
{
    public class Chart : IObserver
    {
        public void Update(string stock, double price)
        {
            Console.WriteLine($"[Chart] Обновление графика: {stock} = {price}");
        }
    }
}
