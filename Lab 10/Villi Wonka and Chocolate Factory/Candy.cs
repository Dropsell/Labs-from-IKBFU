using System;
using System.Collections.Generic;
using System.Text;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class Candy : IFood 
    {
        public string CookNum { get; set; }
        public void Cook(string CookNum)
        {
            Console.WriteLine($"Готовим {CookNum} конфеток");
        }
    }
}
