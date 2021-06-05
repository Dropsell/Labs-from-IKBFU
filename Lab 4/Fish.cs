using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Fish : Animal, IFish
    {
        public Fish()
        {
            ageOfDeath = 2;
        }
        override public int Age { get; set; }
        override public void Eat()
        {
            Console.WriteLine("Кушает корм");
            ChahgeAge(1);
        }
        override public void Drink()
        {
            Console.WriteLine("Пьёт");
            ChahgeAge(1);
        }

        override public void Walk(int step)
        {
            Console.WriteLine("Рыба проплыла {0}.", step);
        }
    }
}
