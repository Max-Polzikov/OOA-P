using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;

namespace AbstractFactory
{
    public class UsualMazeFactory : MazeFactory
    {
        public Maze MakeMaze()
        {
            Console.WriteLine("\tВы создали обычный лабиринт\t");
            return new Maze();
        }

        public Wall MakeWall()
        {
            return new Wall();
        }

        public Room MakeRoom(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                return new Room(n);
            }
        }

        public Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}