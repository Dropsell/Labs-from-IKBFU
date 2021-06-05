using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Hunt : Animal
    {
        override public int Age { get; set; }
        override public void Eat()
        {
            Console.WriteLine("Кушает животное");
            ChahgeAge(1);
        }
        override public void Drink()
        {
            Console.WriteLine("Пьёт");
            ChahgeAge(2);
        }

    }
}
