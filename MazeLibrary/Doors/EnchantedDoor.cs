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
        public EnchantedDoor(Room room1, Room room2) : base(room1, room2) { }
        
        public override void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Вы прошли через магическую дверь из {0} комнаты в {1} комнату", Room1.Number, Room2.Number);
            }
            else
            {
                Console.WriteLine("Дверь заперта");
            }
        }
    }
}
