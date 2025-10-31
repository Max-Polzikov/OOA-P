using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class Maze
    {
        public Maze() { }

        private List<Room> _rooms = new List<Room>();

        public Maze(Maze other)
        {
            foreach (Room room in _rooms)
            {
                _rooms.Add((Room) room.Clone());
            }
        }
        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Maze Clone()
        {
            return new Maze(this);
        }

        public Room RoomNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            var room = _rooms.SingleOrDefault(r => r.Number == number);
            if (room == null)
            {
                throw new ArgumentException($"Комната под номером {number} не найдена");
            }
            Console.WriteLine($"Комната под номером {number} найдена");
            return room;
        }
    }
}
