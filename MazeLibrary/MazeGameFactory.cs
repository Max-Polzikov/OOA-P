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
            Maze _aMaze = new Maze();

            Room _room1 = new Room(1);
            Room _room2 = new Room(2);
            Door _door = new Door(_room1, _room2);

            _aMaze.AddRoom(_room1);
            _aMaze.AddRoom(_room2);

            _room1.SetSide(Direction.North, _door);
            _room1.SetSide(Direction.South, new Wall());
            _room1.SetSide(Direction.West, new Wall());
            _room1.SetSide(Direction.East, new Wall());

            _room2.SetSide(Direction.South, _door);
            _room2.SetSide(Direction.North, new Wall());
            _room2.SetSide(Direction.West, new Wall());
            _room2.SetSide(Direction.East, new Wall());

            return _aMaze;
        }
    }
}
