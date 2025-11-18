using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Turkey
    {
        public void TurkeyType()
        {
            Console.WriteLine("Северокавказский");
        }

        public void TurkeySound()
        {
            Console.WriteLine("гу-гу-гу");
        }

        public void TurkeyAbilityToFly()
        {
            Console.WriteLine("Только на короткие расстояния");
        }
    }
}
