using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Drink();
        abstract public int Age { get; set; }
        protected int ageOfDeath = 20;
        public void Live()
        {
            
            if (Age < ageOfDeath)
            {
                Age++;
            }
            else
            {
                Console.WriteLine("Животное умерло");
            }
        }

        protected void ChahgeAge(int years)
        {
            Age -= years;
        }

        public virtual void Walk(int step)
        {
            Console.WriteLine("Животное прошло {0} шагов.", step);
        }
    }
}
