using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PMWinwowImp : IWindowImp
    {
        private IntPtr _hps;

        public void ImpTop()
        {
            Console.WriteLine("Window raised");
        }

        public void ImpBottom()
        {
            Console.WriteLine("Window lowered");
        }

        public void ImpSetOrigin(Point p)
        {
            Console.WriteLine($"Origin set: {p._x},{p._y}");
        }

        public void ImpSetExtent(Point p)
        {
            Console.WriteLine($"Extent set: {p._x},{p._y}");
        }

        public void DeviceRect(double x0, double y0, double x1, double y1)
        {
            Console.WriteLine($"Draw rect: ({x0},{y0})-({x1},{y1})");
        }

        public void DeviceText(string text, double x, double y)
        {
            Console.WriteLine($"Draw text '{text}' at ({x},{y})");
        }

        public void DeviceBitmap(string name, double x, double y)
        {
            Console.WriteLine($"Draw bitmap '{name}' at ({x},{y})");
        }
    }
}
