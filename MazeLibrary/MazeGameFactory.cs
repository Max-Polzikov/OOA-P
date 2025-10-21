using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class MazeGameFactory
    {
        public Maze CreateMaze()
        {
            Maze aMaze = new Maze();

            Room room1 = new Room(1);
            Room room2 = new Room(2);
            Door door = new Door(room1, room2);

            aMaze.AddRoom(room1);
            aMaze.AddRoom(room2);

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());
            room1.SetSide(Direction.East, new Wall());

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.West, new Wall());
            room2.SetSide(Direction.East, new Wall());

            return aMaze;
        }
    }
}
