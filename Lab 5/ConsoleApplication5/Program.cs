using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void AnimalDo (ILive anim)
        {
            anim.Live();
            anim.Die();
        }

        static void Main(string[] args)
        {
            var lion = new Hunt();
            var antilope = new Traw();
            var shark = new Fish();

            AnimalDo(lion);
            lion.Eat();
            lion.Walk(5);
            lion.Drink();
            Console.WriteLine("");

            AnimalDo(antilope);
            antilope.Eat();
            antilope.Walk(5);
            antilope.Drink();
            Console.WriteLine("");

            AnimalDo(shark);
            shark.Eat();
            shark.Drink();
            Console.WriteLine("");

            //AnimalDo(lion);
            //AnimalDo(antilope);
            //AnimalDo(shark);

            Console.ReadKey();
        }

    }
}
