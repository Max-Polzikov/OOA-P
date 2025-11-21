using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BorderDecorator : Decorator
    {
        private readonly int _width;

        public BorderDecorator(IVisualComponent component, int width) : base(component)
        {
            _width = width;
        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder(_width);
        }

        private void DrawBorder(int width)
        {
            Console.WriteLine("Drawing border width {0}",width);
        }
    }
}
