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

        public override Maze CreateMaze()
        {
            Console.WriteLine("\tВы создали лабиринт с бомбой\t");
            return new Maze();
        }

        public override Wall CreateWall()
        {
            return new BombedWall();
        }

        public override Room CreateRoom(int roomNumber)
        {
            if (roomNumber <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                return new RoomWithBomb(roomNumber);
            }
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}