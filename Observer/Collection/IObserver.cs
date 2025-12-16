using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Collection
{
    public interface IObserver
    {
        void Update(string stock, double price);
    }
}
