using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Hunt : ILive, IEat, IDrink, IWalk
    {
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Кушает животное");
            Age++;
        }
        public void Live()
        {
            Console.WriteLine("Хищник живёт");
            Age++;
        }
        public void Die()
        {
            Console.WriteLine("Хищник умер");
            Age=0;
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
