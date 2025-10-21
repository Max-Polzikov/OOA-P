using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;

namespace AbstractFactory
{
    public class MazeFactory
    {

        public virtual Maze CreateMaze()
        {
            return new Maze();
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public virtual Room CreateRoom(int n)
        {
            return new Room(n);
        }

        public virtual Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
