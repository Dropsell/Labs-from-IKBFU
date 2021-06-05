using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Fish : IEat, ILive, IDrink
    {
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Кушает корм");
            Age++;
        }
        public void Live()
        {
            Console.WriteLine("Рыба живёт");
            Age++;
        }
        public void Die()
        {
            Console.WriteLine("Рыба умерла");
            Age = 0;
        }
        public void Drink()
        {
            Console.WriteLine("Рыба Пьёт");
            Age++;
        }
    }
}
