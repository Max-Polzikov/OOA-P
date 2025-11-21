using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void SetDvd()
        {
            Console.WriteLine("Amplifier setting DVD");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound");
        }
    }
}
