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
        public Maze CreateMaze(IMazeFactory mazeFactory)
        {
            Maze aMaze = mazeFactory.CreateMaze();

            Room room1 = mazeFactory.CreateRoom(1);
            room1.Enter();
            Room room2 = mazeFactory.CreateRoom(2);
            room2.Enter();
            Door door = mazeFactory.CreateDoor(room1, room2);
            door.Enter();

            aMaze.AddRoom(room1);
            aMaze.AddRoom(room2);

            Wall wall = mazeFactory.CreateWall();
            wall.Enter();

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, mazeFactory.CreateWall());
            room1.SetSide(Direction.West, mazeFactory.CreateWall());
            room1.SetSide(Direction.East, mazeFactory.CreateWall());

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.North, mazeFactory.CreateWall());
            room2.SetSide(Direction.West, mazeFactory.CreateWall());
            room2.SetSide(Direction.East, mazeFactory.CreateWall());

            return aMaze;
        }
    }
}
