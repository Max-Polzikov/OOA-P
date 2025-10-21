using MazeLibrary;

namespace Builder
{
    public class MazeBuilder
    {
        Maze _maze = new Maze();
        public virtual void BuildMaze() { }

        public virtual void BuildRoom(int room) { }
        
        public virtual void BuildDoor(int roomFrom, int roomTo) { }

        public virtual Maze GetMaze() { return _maze; }

        protected MazeBuilder() { }
    }
}
