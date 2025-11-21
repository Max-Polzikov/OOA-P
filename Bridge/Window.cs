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
        private IWindowImp _imp;

        public Window(IView contents)
        {
            _contents = contents;
        }

        public virtual void DrawContents() { }

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
            throw new NotImplementedException();
        }

        void IWindow.DrawLine(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            throw new NotImplementedException();
        }

        void IWindow.DrawRect(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            throw new NotImplementedException();
        }

        void IWindow.DrawText(string text, System.Drawing.Point p)
        {
            throw new NotImplementedException();
        }
    }
}
