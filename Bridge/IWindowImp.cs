using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IWindowImp
    {
        public void ImpTop();
        public void ImpBottom();
        public void ImpSetExtent(Point point);
        public void ImpSetOrigin(Point point);

        public void DeviceRect(double x0, double y0, double x1, double y1);
        public void DeviceText(string text, double x, double y);
        public void DeviceBitmap(string bitmapName, double x, double y);
    }
}
