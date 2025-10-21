using MazeLibrary.Rooms;
namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        public Room _room1;
        public Room _room2;
        protected bool _isOpen {  get; set; }

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
            _isOpen = true;
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == _room1)
            {
                return _room2;
            }
            if (room == _room2)
            {
                return _room1;
            }
            else
            {
                throw new Exception("Данной комнаты не существует");
            }
        }

        public override void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Вы прошли через дверь из {0} комнаты в {1}", _room1.RoomNumber, _room2.RoomNumber);
            }
            else
            {
                Console.WriteLine("Дверь заперта");
            }
        }
    }
}
