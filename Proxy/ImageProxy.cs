using System;

public class ImageProxy : IGraphic
{
    private string _fileName;
    private Image _image;
    private Point _extent = Point.Zero;

    public ImageProxy(string fileName)
    {
        _fileName = fileName;
    }

    protected Image GetImage()
    {
        if (_image == null)
        {
            _image = new Image(_fileName);
        }
        return _image;
    }

    public void Draw(Point at)
    {
        GetImage().Draw(at);
    }

    public void HandleMouse(Event evt)
    {
        GetImage().HandleMouse(evt);
    }

    public Point GetExtent()
    {
        if (_extent == Point.Zero)
        {
            _extent = GetImage().GetExtent();
        }
        return _extent;
    }

    public void Load(StreamReader from)
    {
        _fileName = from.ReadLine();
    }

    public void Save(StreamWriter to)
    {
        to.WriteLine($"{_extent.X} {_extent.Y}");
        to.WriteLine(_fileName);
    }
}
