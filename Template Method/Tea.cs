using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем лимон");
        }
    }

}
