using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AbstractFactory
{
    public class MazeGameFactory
    {
        public MazeGameFactory() { }
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            Maze _aMaze = mazeFactory.CreateMaze();

            Room _room1 = mazeFactory.CreateRoom(1);
            _room1.Enter();
            Room _room2 = mazeFactory.CreateRoom(2);
            _room2.Enter();
            Door _door = mazeFactory.CreateDoor(_room1, _room2);
            _door.Enter();

            _aMaze.AddRoom(_room1);
            _aMaze.AddRoom(_room2);

            Wall _wall = mazeFactory.CreateWall();
            _wall.Enter();

            _room1.SetSide(Direction.North, _door);
            _room1.SetSide(Direction.South, mazeFactory.CreateWall());
            _room1.SetSide(Direction.West, mazeFactory.CreateWall());
            _room1.SetSide(Direction.East, mazeFactory.CreateWall());

            _room2.SetSide(Direction.South, _door);
            _room2.SetSide(Direction.North, mazeFactory.CreateWall());
            _room2.SetSide(Direction.West, mazeFactory.CreateWall());
            _room2.SetSide(Direction.East, mazeFactory.CreateWall());

            return _aMaze;
        }
    }
}
