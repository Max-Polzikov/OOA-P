using MazeBridge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Window : IWindow
    {
        private readonly IView _contents;
        protected IWindowImp _imp;

        public Window(IView contents, IWindowImp imp)
        {
            _contents = contents ?? throw new ArgumentNullException(nameof(contents));
            _imp = imp ?? throw new ArgumentNullException(nameof(imp));
        }

        public Window(IView contents)
        {
            _contents = contents;
        }

        public virtual void DrawContents() 
        {
            var imp = GetImp();
            if (imp != null)
                imp.DeviceRect(0, 0, 100, 100);
        }

        public virtual void Open() { }
        public virtual void Close() { }
        public virtual void Iconify() { }
        public virtual void Deiconify() { }

        // Bridge calls
        public void SetOrigin(Point at)
        {
            GetImp().ImpSetOrigin(at);
        }

        public void SetExtent(Point extent)
        {
            GetImp().ImpSetExtent(extent);
        }

        public void Raise()
        {
            GetImp().ImpTop();
        }

        public void Lower()
        {
            GetImp().ImpBottom();
        }

        public void DrawLine(Point point1, Point point2) { }

        public void DrawRect(Point point1, Point point2)
        {
            var imp = GetImp();
            imp.DeviceRect(point1._x, point1._y, point2._x, point2._y);
        }

        public void DrawText(string text, Point point)
        {
            GetImp().DeviceText(text, point._x, point._y);
        }

        // Helpers
        protected IWindowImp GetImp()
        {
            return _imp;
        }

        protected IView GetView()
        {
            return _contents;
        }

        void IWindow.SetOrigin(System.Drawing.Point at)
        {
            SetOrigin(new Point(at.X, at.Y));
        }

        void IWindow.SetExtent(System.Drawing.Point extent)
        {
            SetExtent(new Point(extent.X, extent.Y));
        }
        void IWindow.DrawLine(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            SetExtent(new Point(p1.X, p2.Y));
        }

        void IWindow.DrawRect(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            SetExtent(new Point(p1.X, p2.Y));
        }

        void IWindow.DrawText(string text, System.Drawing.Point p)
        {
            SetExtent(new Point(p.X, p.Y));
        }
    }
}
