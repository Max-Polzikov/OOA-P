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
        void ImpTop();
        void ImpBottom();
        void ImpSetExtent(Point point);
        void ImpSetOrigin(Point point);

        void DeviceRect(double x0, double y0, double x1, double y1);
        void DeviceText(string text, double x, double y);
        void DeviceBitmap(string bitmapName, double x, double y);
    }
}
