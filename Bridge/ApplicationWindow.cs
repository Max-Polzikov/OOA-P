using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class ApplicationWindow : Window
    {
        private readonly IView _view;
        public ApplicationWindow(IView contents) : base(contents)
        {
            _view = contents ?? throw new ArgumentNullException(nameof(contents));
        }

        public override void DrawContents()
        {
            _view?.DrawOn(this);
        }
    }
}
