using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeFactoryMethod
{
    class BombedMazeGame : MazeGame
    {
        public BombedMazeGame() { }

        protected override Maze MakeMaze()
        {
            return new Maze(); 
        }
        protected override Wall MakeWall()
        {
            return new BombedWall();
        }

        protected override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}
