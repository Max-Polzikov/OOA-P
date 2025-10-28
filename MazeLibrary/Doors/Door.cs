using MazeLibrary.Rooms;
namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        public Door() { }
        protected Room Room1 { get; set; }
        protected Room Room2 { get; set; }
        protected bool IsOpen { get; set; }

        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
            IsOpen = true;
        }

        public Door(Door door)
        {
            Room1 = door.Room1;
            Room2 = door.Room2;
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == Room1)
            {
                return Room2;
            }
            if (room == Room2)
            {
                return Room1;
            }
            throw new Exception("Данной комнаты не существует");
        }

        public virtual Door Clone()
        {
            return new Door(this);
        }

        public void Initialize(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
        }

        public override void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Вы прошли через дверь из {0} комнаты в {1}", Room1.Number, Room2.Number);
            }
            else
            {
                Console.WriteLine("Дверь заперта");
            }
        }
    }
}
