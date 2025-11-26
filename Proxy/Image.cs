using System;
namespace Proxy
{
    public class Image : IGraphic
    {
        private string _fileName;
        private Point _extent;

        public Image(string file)
        {
            _fileName = file;
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            _extent = new Point(100, 100);
            Console.WriteLine($"Image Loaded {_fileName}");
        }

        public void Draw(Point at)
        {
            Console.WriteLine($"Image Draw at {at}");
        }

        public void HandleMouse(Event evt)
        {
            Console.WriteLine("Image HandleMouse — resizing image interactively");
        }

        public Point GetExtent()
        {
            return _extent;
        }

        public void Load(StreamReader from)
        {
            _fileName = from.ReadLine();
        }

        public void Save(StreamWriter to)
        {
            to.WriteLine(_fileName);
        }
    }
}