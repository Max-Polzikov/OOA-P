using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(IVisualComponent component) : base(component) { }

        public override void Draw()
        {
            base.Draw();
            DrawScrollBar();
        }

        private void DrawScrollBar()
        {
            Console.WriteLine("Drawing scroll bar");
        }
    }
}
