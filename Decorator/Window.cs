using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Window
    {
        private IVisualComponent? _contents;

        public void SetContents(IVisualComponent component)
        {
            _contents = component;
        }

        public void Draw()
        {
            _contents?.Draw();
        }
    }
}
