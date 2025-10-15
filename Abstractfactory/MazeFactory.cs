using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;

namespace AbstractFactory
{
    public class MazeFactory
    {
        public MazeFactory() { }

        public Maze CreateMaze()
        {
            return new Maze();
        }

        public Wall CreateWall()
        {
            return new Wall();
        }

        public Room CreateRoom(int n)
        {
            return new Room(n);
        }

        public Door CreateDoor(Room _room1, Room _room2)
        {
            return new Door(_room1, _room2);
        }
    }
}
