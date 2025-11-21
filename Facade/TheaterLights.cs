using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TheaterLights
    {
        public void Dim(int level)
        {
            Console.WriteLine($"Lights dimming to {level}%");
        }
    }
}
