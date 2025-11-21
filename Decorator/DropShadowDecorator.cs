using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DropShadowDecorator : Decorator
    {
        public DropShadowDecorator(IVisualComponent component) : base(component) { }

        public override void Draw()
        {
            base.Draw();
            DrawShadow();
        }

        private void DrawShadow()
        {
            Console.WriteLine(" Drawing drop shadow");
        }
    }
}
