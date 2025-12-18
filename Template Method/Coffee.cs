using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем сахар и молоко");
        }
    }

}
