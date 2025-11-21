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

        public void ImpTop() => throw new NotImplementedException();
        public void ImpBottom() => throw new NotImplementedException();
        public void ImpSetExtent(Point point) => throw new NotImplementedException();
        public void ImpSetOrigin(Point point) => throw new NotImplementedException();

        public void DeviceRect(double x0, double y0, double x1, double y1)
        {
            double left = Math.Min(x0, x1);
            double right = Math.Max(x0, x1);
            double bottom = Math.Min(y0, y1);
            double top = Math.Max(y0, y1);
        }

        public void DeviceText(string text, double x, double y) => throw new NotImplementedException();

        public void DeviceBitmap(string bitmapName, double x, double y) => throw new NotImplementedException();
    }
}
