using MazeLibrary;

namespace Builder
{
    public class MazeBuilder
    {
        Maze _maze = new Maze();
        public virtual void BuildMaze() { }

        public virtual void BuildRoom(int _room) { }
        
        public virtual void BuildDoor(int _roomFrom, int _roomTo) { }

        public virtual Maze GetMaze() { return _maze; }

        protected MazeBuilder() { }
    }
}
