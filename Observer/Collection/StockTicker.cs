using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Collection
{
    public class StockTicker
    {
        private Dictionary<string, double> _prices = new Dictionary<string, double>();
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetPrice(string stock, double price)
        {
            _prices[stock] = price;
            Notify(stock, price);
        }

        private void Notify(string stock, double price)
        {
            foreach (var observer in _observers)
            {
                observer.Update(stock, price);
            }
        }
    }
}
