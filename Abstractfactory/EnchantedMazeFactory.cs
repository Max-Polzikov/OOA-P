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

        public Maze MakeMaze()
        {
            Console.WriteLine("\tВы создали магический лабиринт\t");
            return new Maze();
        }

        public Room MakeRoom(int n)
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

        public Door MakeDoor(Room _room1, Room _room2)
        {
            return new EnchantedDoor(_room1, _room2);
        }

        public Wall MakeWall()
        {
            return new Wall();
        }
    }
}
