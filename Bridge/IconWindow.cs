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
            _bitmapName = bitmapName;
        }

        public override void DrawContents() 
        {
            var imp = GetImp();
            if (imp != null)
            {
                imp.DeviceBitmap(_bitmapName, 0.0, 0.0);
            }

        }
    }
}
