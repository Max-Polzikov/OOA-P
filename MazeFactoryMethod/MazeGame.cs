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
        public Maze CreateMaze() { }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Door MakeDoor(Room roomFrom, Room roomTo)
        {
            return new Door(roomFrom, roomTo);
        }
    }
}
