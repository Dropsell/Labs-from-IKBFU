using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            var europa = new ShopingCenter();
            var mcDonalds = new Restaurant(europa);
            var pullandbear = new Shop(europa);
            var karo = new Cinema(europa);
            /*europa.NotifyTime += mcDonalds.Close;
            europa.NotifyTime += pullandbear.Close;
            europa.NotifyTime += karo.Close;*/
            for (int i = 0; i < 30; i++)
            {
                europa.setTimeHour(i);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
