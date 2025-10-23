using MazeLibrary;
using MazeLibrary.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CountingMazeBuilder : IMazeBuilder
    {
        private int _rooms;
        private int _doors;
        private Maze _currentMaze;
        public CountingMazeBuilder() 
        {
            _rooms = 0;
            _doors = 0;
        }

        public void BuildMaze() 
        {
            _currentMaze = new Maze();
        }

        public Maze GetMaze()
        {
            return _currentMaze;
        }

        public void BuildRoom (int number) 
        {
            _rooms ++;
        }

        public void BuildDoor(int roomFrom, int roomTo) 
        {
            _doors ++;
        }

        public virtual void AddWall(int roomNumber, Direction direction) { }

        public ( int rooms,  int doors) GetCounts()
        {
            return (_rooms, _doors);
            
        }
    }
}
