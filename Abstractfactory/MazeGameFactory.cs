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
            Maze aMaze = mazeFactory.CreateMaze();

            Room r1 = mazeFactory.CreateRoom(1);
            r1.Enter();
            Room r2 = mazeFactory.CreateRoom(2);
            r2.Enter();
            Door door = mazeFactory.CreateDoor(r1, r2);
            door.Enter();

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            Wall wall = mazeFactory.CreateWall();
            wall.Enter();

            r1.SetSide(Direction.North, door);
            r1.SetSide(Direction.South, mazeFactory.CreateWall());
            r1.SetSide(Direction.West, mazeFactory.CreateWall());
            r1.SetSide(Direction.East, mazeFactory.CreateWall());

            r2.SetSide(Direction.South, door);
            r2.SetSide(Direction.North, mazeFactory.CreateWall());
            r2.SetSide(Direction.West, mazeFactory.CreateWall());
            r2.SetSide(Direction.East, mazeFactory.CreateWall());

            return aMaze;
        }
    }
}
