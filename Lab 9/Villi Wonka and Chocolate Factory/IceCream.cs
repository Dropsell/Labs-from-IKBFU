using System;
using System.Collections.Generic;
using System.Text;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class IceCream : IFood
    {
        public string CookNum { get; set; }
        public void Cook(string CookNum)
        {
            Console.WriteLine($"Готовим {CookNum} мороженых");
        }
    }
}
