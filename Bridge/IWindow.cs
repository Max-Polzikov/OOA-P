using System.Drawing;

namespace MazeBridge
{
    public interface IWindow
    {
        void DrawContents();

        void Open();
        void Close();
        void Iconify();
        void Deiconify();

        void SetOrigin(Point at);
        void SetExtent(Point extent);
        void Raise();
        void Lower();
        void DrawLine(Point p1, Point p2);
        void DrawRect(Point p1, Point p2);
        void DrawText(string text, Point p);
    }
}
