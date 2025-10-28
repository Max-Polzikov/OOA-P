using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
namespace Prototype
{
    public interface IPrototype
    {
        Maze MakeMaze();
        Room MakeRoom(int number);
        Wall MakeWall();
        Door MakeDoor(Room roomFrom, Room roomTo);
    }
}
