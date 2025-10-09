using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class Maze
    {
        public Maze() { }
        private List<Room> Rooms = new List<Room>();
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public Room RoomNumber(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                var room = Rooms.FirstOrDefault(r => r.Roomnumber == n);
                if (room != null)
                {
                    Console.WriteLine($"Комната под номером {n} найдена");
                    return room;
                }
                else
                {
                    throw new ArgumentException($"Комната под номером {n} не найдена");
                }
            }
        }
    }
}
