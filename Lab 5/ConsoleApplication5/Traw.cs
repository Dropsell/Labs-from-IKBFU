using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Traw : IEat, ILive, IWalk, IDrink
    {
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Кушает траву");
            Age++;
        }
        public void Live()
        {
            Console.WriteLine("Травоядное живёт");
            Age++;
        }
        public void Die()
        {
            Console.WriteLine("Травоядное умер");
            Age = 0;
        }
        public void Drink()
        {
            Console.WriteLine("Пьёт");
            Age++;
        }
        public void Walk(int step)
        {
            Console.WriteLine("Животное прошло {0} шагов.", step);
        }
     }
}
