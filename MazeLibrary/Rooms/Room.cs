namespace MazeLibrary.Rooms
{
    public class Room : MapSite
    {
        private MapSite[] _sides = new MapSite[4];
        public Room(int n)
        {
            RoomNumber = n;
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction dir, MapSite mapsite)
        {
            _sides[(int)dir] = mapsite;
        }

        public override void Enter()
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
