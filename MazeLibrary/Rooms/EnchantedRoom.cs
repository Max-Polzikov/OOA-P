using MazeLibrary.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public EnchantedRoom(int number) : base(number)
        {
            _spell = new Spell("Шары мары");
        }

        public void CastSpell()
        {
            Console.WriteLine("Вы активировали заклинание");
        }

        public void Enter()
        {
            Console.WriteLine("Вы вошли в комнату");
        }

        public override Room Clone()
        {
            return new EnchantedRoom(this);
        }

        public EnchantedRoom(EnchantedRoom other) : base(other)
        {
            _spell = other._spell;
        }

        public void Initialize(Spell spell)
        {
            _spell = spell;
        }
    }
}
