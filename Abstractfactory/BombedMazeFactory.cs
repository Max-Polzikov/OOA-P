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
    public class BombedMazeFactory : MazeFactory
    {
        public BombedMazeFactory() { }

        public Maze CreateCreate()
        {
            Console.WriteLine("\tВы создали лабиринт с бомбой\t");
            return new Maze();
        }

        public Wall CreateWall()
        {
            return new BombedWall();
        }

        public Room CreateRoom(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                return new RoomWithBomb(n);
            }
        }

        public Door CreateDoor(Room _room1, Room _room2)
        {
            return new Door(_room1, _room2);
        }
    }
}