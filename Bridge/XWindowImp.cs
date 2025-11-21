using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class XWindowImp : IWindowImp
    {
        private IntPtr _dpy;
        private IntPtr _winid;
        private IntPtr _gc;

        public void ImpTop() => throw new NotImplementedException();
        public void ImpBottom() => throw new NotImplementedException();
        public void ImpSetExtent(Point point) => throw new NotImplementedException();
        public void ImpSetOrigin(Point point) => throw new NotImplementedException();

        public void DeviceRect(double x0, double y0, double x1, double y1)
        {
            int x = (int)Math.Round(Math.Min(x0, x1));
            int y = (int)Math.Round(Math.Min(y0, y1));
            int w = (int)Math.Round(Math.Abs(x0 - x1));
            int h = (int)Math.Round(Math.Abs(y0 - y1));
        }

        public void DeviceText(string text, double x, double y) => throw new NotImplementedException();

        public void DeviceBitmap(string bitmapName, double x, double y) => throw new NotImplementedException();
    }
}
