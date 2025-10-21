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
    public class EnchantedMazeFactory : MazeFactory
    {
        public EnchantedMazeFactory() { }

        public override Maze CreateMaze()
        {
            Console.WriteLine("\tВы создали магический лабиринт\t");
            return new Maze();
        }

        public override Room CreateRoom(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                return new EnchantedRoom(n);
            }
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            return new EnchantedDoor(room1, room2);
        }

        public override Wall CreateWall()
        {
            return new Wall();
        }
    }
}
