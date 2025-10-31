using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MazeGame
    {
        public void CreateMaze(IMazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            builder.BuildMaze();
        }
    }
}
