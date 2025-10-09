using MazeLibrary.Rooms;
namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        private Room Room1;
        private Room Room2;
        private bool IsOpen;

        public Door(Room r1, Room r2)
        {
            Room1 = r1;
            Room2 = r2;
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
            return room;
        }
        public override void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Вы прошли через дверь из {0} комнаты в {1}", Room1.Roomnumber, Room2.Roomnumber);
            }
            else
            {
                Console.WriteLine("Дверь заперта");
            }
        }
    }
}
