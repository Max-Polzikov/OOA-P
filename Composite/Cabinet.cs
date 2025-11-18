using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Cabinet : CompositeEquipment
    {
        public Cabinet(string name) : base(name) { }
    }
}
