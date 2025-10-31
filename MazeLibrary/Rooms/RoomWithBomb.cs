using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MazeLibrary.Rooms
{
    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int number) : base(number) { }


        private bool _bomb;

        public void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой");
        }

        public override Room Clone()
        {
            return new RoomWithBomb(this);
        }

        public RoomWithBomb(RoomWithBomb other) : base(other)
        {
            _bomb = other._bomb;
        }

        public void Initialize(bool bomb)
        {
            _bomb = bomb;
        }
    }
}
