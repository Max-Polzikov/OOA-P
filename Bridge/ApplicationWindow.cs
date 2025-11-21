using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class ApplicationWindow : Window
    {
        public IView _view { get; set; }
        public ApplicationWindow(IView contents) : base(contents)
        {
            _view =contents;
        }

        public override void DrawContents()
        {
            _view?.DrawOn(this);
        }
    }
}
