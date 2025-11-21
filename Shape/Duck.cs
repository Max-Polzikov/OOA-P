using System.Drawing;

namespace Adapter
{
    public class Duck : IDuck
    {
        public void Type()
        {
            Console.WriteLine("Кряква");
        }

        public void Sound()
        {
            Console.WriteLine("Кря-кря");
        }

        public void TheAbilityToFly()
        {
            Console.WriteLine("Может летать");
        }
    }
}
