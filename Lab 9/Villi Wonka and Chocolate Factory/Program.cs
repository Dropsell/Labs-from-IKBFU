using System;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var Factory = new Machine (); 
            while (true) {
                Console.WriteLine("Choose Machine:");
                var key = Console.ReadLine();
                IFood newTask = null;
                switch (key)
                {
                    case "co":
                        newTask = Factory.СhocolateCraft();
                        break;
                    case "ca":
                        newTask = Factory.СandyCraft();
                        break;
                    case "le":
                        newTask = Factory.LemonadeCraft();
                        break;
                    case "ic":
                        newTask = Factory.IceCreamCraft();
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
