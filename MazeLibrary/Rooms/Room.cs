namespace MazeLibrary.Rooms
{
    public class Room : IMapSite
    {
        private IMapSite[] _sides = new IMapSite[4];

        public int Number { get; private set; }

        public Room(int number)
        {
            Number = number;
        }

        public Room(Room other)
        {
            Number = other.Number;
        }

        public virtual IMapSite Clone()
        {
            return new Room(this);
        }

        public void Initialize(int number)
        {
            Number = number;
        }

        public IMapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction dir, IMapSite mapsite)
        {
            _sides[(int)dir] = mapsite;
        }

        public void Enter()
        {
            Console.WriteLine("Вы вошли в комнату под номеров {0}", Number);
        }
    }
}
