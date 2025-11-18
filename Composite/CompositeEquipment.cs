using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CompositeEquipment : IEquipment
    {
        public string Name { get; }

        protected readonly List<IEquipment> _equipment = new List<IEquipment>();

        public CompositeEquipment(string name)
        {
            Name = name;
        }

        public virtual double Power()
        {
            return _equipment.Sum(e => e.Power());
        }

        public virtual decimal NetPrice()
        {
            return _equipment.Sum(e => e.NetPrice());
        }

        public virtual decimal DiscountPrice()
        {
            return _equipment.Sum(e => e.DiscountPrice());
        }

        public virtual void Add(IEquipment e)
        {
            _equipment.Add(e);
        }

        public virtual void Remove(IEquipment e)
        {
            _equipment.Remove(e);
        }
    }
}
