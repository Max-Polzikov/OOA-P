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

        public Door CreateDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}
