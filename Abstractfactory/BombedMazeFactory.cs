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
    public class BombedMazeFactory : IMazeFactory
    {
        public BombedMazeFactory() { }

        public Maze CreateMaze()
        {
            Console.WriteLine("\tВы создали лабиринт с бомбой\t");
            return new Maze();
        }

        public Wall CreateWall()
        {
            return new BombedWall();
        }

        public Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new RoomWithBomb(number);
        }

        public Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}