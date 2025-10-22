using MazeLibrary.Rooms;
namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        protected Room Room1 { get; set; }
        protected Room Room2 { get; set; }
        protected bool IsOpen {  get; set; }

        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
            IsOpen = true;
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
            else
            {
                throw new Exception("Данной комнаты не существует");
            }
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
