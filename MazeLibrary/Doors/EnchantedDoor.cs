using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;

namespace MazeLibrary.Doors
{
    public class EnchantedDoor : Door
    {
        public EnchantedDoor(Room room1, Room room2) : base(room1, room2)
        {
            _room1 = room1;
            _room2 = room2;
            _isOpen = true;
        }

        public override void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Вы прошли через магическую дверь из {0} комнаты в {1} комнату", _room1.RoomNumber, _room2.RoomNumber);
            }
            else
            {
                Console.WriteLine("Дверь заперта");
            }
        }
    }
}
