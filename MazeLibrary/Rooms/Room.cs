namespace MazeLibrary.Rooms
{
    public class Room : MapSite
    {
        private MapSite[] sides = new MapSite[4];
        public Room(int n)
        {
            RoomNumber = n;
        }

        public MapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction dir, MapSite mapsite)
        {
            sides[(int)dir] = mapsite;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в комнату под номеров {0}", RoomNumber);
        }

        public int RoomNumber
        {
            get;
            private init;
        }
    }
}
