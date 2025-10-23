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
    public class UsualMazeFactory : IMazeFactory
    {
        public Maze CreateMaze()
        {
            Console.WriteLine("\tВы создали обычный лабиринт\t");
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
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new Room(number);
        }

        public Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}