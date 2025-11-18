using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class FloppyDisk : IEquipment
    {
        public string Name { get; }
        private readonly double _power;
        private readonly decimal _netPrice;
        private readonly decimal _discountPrice;

        public FloppyDisk(string name, double power = 5, decimal netPrice = 20, decimal discountPrice = 15)
        {
            Name = name;
            _power = power;
            _netPrice = netPrice;
            _discountPrice = discountPrice;
        }

        public double Power()
        {
            return _power;
        }

        public decimal NetPrice()
        {
            return _netPrice;
        }

        public decimal DiscountPrice()
        {
            return _discountPrice;
        }

        public void Add(IEquipment e)
        {
            throw new NotSupportedException();
        }

        public void Remove(IEquipment e)
        {
            throw new NotSupportedException();
        }
    }
}
