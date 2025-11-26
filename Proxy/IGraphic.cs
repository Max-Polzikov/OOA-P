using System;
namespace Proxy
{
    public interface IGraphic
    {
        void Draw(Point at);

        void HandleMouse(Event evt);

        Point GetExtent();

        void Load(StreamReader from);

        void Save(StreamWriter to);
    }
}