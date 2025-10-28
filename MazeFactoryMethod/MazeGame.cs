using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
namespace MazeFactoryMethod
{
    public class MazeGame : Maze
    {

        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        protected virtual Wall MakeWall()
        {
            return new Wall();
        }

        protected virtual Door MakeDoor(Room roomFrom, Room roomTo)
        {
            return new Door(roomFrom, roomTo);
        }
        public Maze CreateMaze()
        {
            Maze maze = MakeMaze();
            Room room1 = MakeRoom(1);
            Room room2 = MakeRoom(2);
            Door door = MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, MakeWall());
            room1.SetSide(Direction.West, MakeWall());

            room2.SetSide(Direction.North, MakeWall());
            room2.SetSide(Direction.East, MakeWall());
            room2.SetSide(Direction.South, MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
