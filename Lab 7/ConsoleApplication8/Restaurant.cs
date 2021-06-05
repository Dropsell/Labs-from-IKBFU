using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Restaurant
    {
        private ShopingCenter mall;
        public Restaurant(ShopingCenter newMall)
        {
            mall = newMall;
            mall.NotifyTime += Close;
        }
        public void Close(object sender, TrahHolderEventArgs e)
        {
            if ((e.timeHour > 3) && (e.timeHour < 12))
            {
                Console.WriteLine("Restaurant closed");
            }
            else
            {
                Console.WriteLine("Restaurant open");
            }
        }
        ~Restaurant()
        {
            mall.NotifyTime -= Close;
        }
    }
}
