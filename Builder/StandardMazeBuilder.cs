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
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze = new Maze();
        public StandardMazeBuilder() { }

        public virtual void BuildMaze() { }

        public virtual void BuildRoom(int roomNumber) 
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

        public virtual void BuildDoor(int _roomFrom, int _roomTo) 
        {
            Room _room1 = new Room(_roomFrom);
            Room _room2 = new Room(_roomTo);
            Door _door = new Door(_room1,_room2);

            _room1.SetSide(CommonWall(_room1,_room2), _door);
            _room2.SetSide(CommonWall(_room2, _room1), _door);
        }

        public virtual Maze GetMaze() { return _currentMaze; }

        private Direction CommonWall(Room _room1, Room _room2) { return Direction.North; }

        public virtual void StandartMazeBuilder() { _currentMaze = new Maze(); }
    }
}
