using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decorator : IVisualComponent
    {
        protected readonly IVisualComponent Component;

        public Decorator(IVisualComponent component)
        {
            Component = component ?? throw new ArgumentNullException(nameof(component));
        }

        public virtual void Draw()
        {
            Component.Draw();
        }

        public virtual void Resize()
        {
            Component.Resize();
        }
    }
}
