using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        private int _rooms;
        private int _doors;
        public CountingMazeBuilder() 
        {
            _rooms = 0;
            _doors = 0;
        }

        public virtual void BuildMaze() { }

        public virtual void BuldRoom (int rooNumber) 
        {
            _rooms ++;
        }

        public virtual void BuildDoor(int roomFrom, int roomTo) 
        {
            _doors ++;
        }

        public virtual void AddWall(int roomNumber, Direction direction) { }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = _rooms;
            doors = _doors;
        }
    }
}
