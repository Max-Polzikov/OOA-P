using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;

namespace AbstractFactory
{
    public interface IMazeFactory
    {
        Maze CreateMaze();
        Wall CreateWall();
        Room CreateRoom(int number);
        Door CreateDoor(Room room1, Room room2);
    }
}
