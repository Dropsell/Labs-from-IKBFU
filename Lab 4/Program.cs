using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void AnimalDo (Animal anim)
        {
            anim.Live();
            anim.Eat();
            anim.Walk(5);
            anim.Drink();
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            var lion = new Hunt();
            var antilope = new Traw();
            var shark = new Fish();

            AnimalDo(lion);
            AnimalDo(antilope);
            AnimalDo(shark);

            Console.ReadKey();
        }

    }
}
