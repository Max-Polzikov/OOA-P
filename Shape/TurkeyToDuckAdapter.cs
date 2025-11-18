using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class TurkeyToDuckAdapter :IBirds
    {
        private Turkey _turkey;

        public TurkeyToDuckAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Type()
        {
            _turkey.TurkeyType();
        }

        public void Sound()
        {
            _turkey.TurkeySound();
        }

        public void TheAbilityToFly()
        {
            _turkey.TurkeyAbilityToFly();
        }
    }
}
