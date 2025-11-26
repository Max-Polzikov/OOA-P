using System;
namespace Proxy
{
    public class TextDocument
    {
        private readonly List<IGraphic> _graphics = new();

        public void Insert(IGraphic graphic)
        {
            _graphics.Add(graphic);
        }
    }
}