using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class EnchantedRoom : Room
    {
        private Spell spell;
        private int roomnumber;
        private MapSite[] sides = new MapSite[4];

        public EnchantedRoom(int n) : base(n)
        {
            this.spell = spell;
        }
        public void CastSpell()
        {
            Console.WriteLine("Вы активировали заклинание");
        }
        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в комнату");
        }
    }
}
