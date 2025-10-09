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
    public class MazeGameFactory : Maze
    {
        public Maze CreateMaze()
        {
            Maze aMaze = new Maze();

            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door door = new Door(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, door);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());
            r1.SetSide(Direction.East, new Wall());

            r2.SetSide(Direction.South, door);
            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.West, new Wall());
            r2.SetSide(Direction.East, new Wall());

            return aMaze;
        }
    }
}
