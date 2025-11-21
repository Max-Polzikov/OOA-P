using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class IconWindow : Window 
    {
        private readonly string _bitmapName;

        public IconWindow(IView contents, string bitmapName) : base(contents)
        {
            _bitmapName = bitmapName ?? throw new ArgumentNullException(nameof(bitmapName));
        }

        public override void DrawContents() 
        {
            var imp = GetImp() ?? throw new InvalidOperationException("No window implementation");

            imp.DeviceBitmap(_bitmapName, 0, 0);

        }
    }
}
