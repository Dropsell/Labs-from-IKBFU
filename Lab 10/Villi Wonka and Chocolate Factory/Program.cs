using System;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new BildingFactory();
            var villi = world.Villi(); 
            while (true) {
                Console.WriteLine("Choose Machine:");
                var key = Console.ReadLine();
                IFood newTask = null;
                switch (key)
                {
                    case "co":
                        newTask = villi.СhocolateCraft();
                        break;
                    case "ca":
                        newTask = villi.СandyCraft();
                        break;
                    case "le":
                        newTask = villi.LemonadeCraft();
                        break;
                    case "ic":
                        newTask = villi.IceCreamCraft();
                        break;

                    default:
                        return;
                }
                Console.WriteLine("Kol-vo:");
                string num = Console.ReadLine();
                newTask.Cook(num);
                Console.WriteLine("");
            }
        }
    }
}
