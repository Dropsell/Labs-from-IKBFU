using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            var party1 = new Dell(i => { Console.WriteLine("ghhgh"); } );
            var party2 = new Dell(i => { Console.WriteLine("ghhgh"); }, j => { Console.WriteLine("asdasd"); }, z => { Console.WriteLine("qwer"); });
            var party3 = new Dell();
            party1.DoSomethng();
            party2.DoSomethng();
            //party3.DoSomethng();

            var evening1 = new FuncAction(() => Console.WriteLine("Action") );
            var evening2 = new FuncAction((x,y) => x + y);
            var evening3 = new FuncAction(() => Console.WriteLine("Action2"), (x, y) => x + y);


            evening2.Act();
            evening1.Act();
            Console.WriteLine(evening2.fun(1, 2));
            evening3.Act();
            Console.WriteLine(evening3.fun(2,  3));
            Console.ReadKey();
        }


    }
}
