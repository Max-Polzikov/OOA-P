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

        public void Enter()
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

        public override Door Clone()
        {
            return new EnchantedDoor(this);
        }

        public EnchantedDoor(EnchantedDoor other) 
        {
            Room1 = other.Room1;
            Room2 = other.Room2;
        }

        public void Initialize(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
        }
    }
}
