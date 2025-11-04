using AbstractFactory;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using MazeLibrary;
namespace MazeSingltoneFactory
{
    public class MazeSingltoneFactory : IMazeFactory
    {
        private static IMazeFactory _instance = null;

        private MazeSingltoneFactory () { }
        public static IMazeFactory Instance() 
        {
            if (_instance == null)
            {
                _instance = new MazeSingltoneFactory();
            }
            return _instance;
        }

        public Maze CreateMaze()
        {
            return new Maze();
        }

        public Wall CreateWall()
        {
            return new Wall();
        }

        public Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным");
            }
            return new Room(number);
        }

        public Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }



    }
}
