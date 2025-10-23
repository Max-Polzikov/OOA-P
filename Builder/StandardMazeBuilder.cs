using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;

namespace Builder
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder() { }

        public Maze GetMaze() 
        { 
            return _currentMaze; 
        }

        private Direction CommonWall(Room room1, Room room2) 
        { 
            return Direction.North; 
        }

        public virtual void StandartMazeBuilder() 
        { 
            _currentMaze = new Maze(); 
        }

        public void BuildMaze() { }

        public void BuildRoom(int roomNumber) 
        {
            if (_currentMaze.RoomNumber(roomNumber)==null)
            {
                Room room = new Room(roomNumber);
                _currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public void BuildDoor(int roomFrom, int roomTo) 
        {
            Room room1 = new Room(roomFrom);
            Room room2 = new Room(roomTo);
            Door door = new Door(room1,room2);

            room1.SetSide(CommonWall(room1, room2), door);
            room2.SetSide(CommonWall(room2, room1), door);
        }
    }
}
