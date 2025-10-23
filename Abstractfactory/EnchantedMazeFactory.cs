using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
namespace AbstractFactory
{
    public class EnchantedMazeFactory : IMazeFactory
    {
        public EnchantedMazeFactory() { }

        public Maze CreateMaze()
        {
            Console.WriteLine("\tВы создали магический лабиринт\t");
            return new Maze();
        }

        public Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new EnchantedRoom(number);
        }

        public Door CreateDoor(Room room1, Room room2)
        {
            return new EnchantedDoor(room1, room2);
        }

        public Wall CreateWall()
        {
            return new Wall();
        }
    }
}
