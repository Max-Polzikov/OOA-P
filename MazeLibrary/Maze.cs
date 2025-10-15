using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class Maze
    {
        public Maze() { }

        private List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room RoomNumber(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            var room = _rooms.FirstOrDefault(r => r.RoomNumber == n);
            if (room == null)
            {
                throw new ArgumentException($"Комната под номером {n} не найдена");
            }
            Console.WriteLine($"Комната под номером {n} найдена");
            return room;
        }
    }
}
