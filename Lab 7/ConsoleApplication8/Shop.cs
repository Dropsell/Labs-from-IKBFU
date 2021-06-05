using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Shop
    {
        private ShopingCenter mall;
        public Shop(ShopingCenter newMall) 
        {
            mall = newMall;
            mall.NotifyTime += Close;
        } 
        public void Close(object sender, TrahHolderEventArgs e)
        {
            if ((e.timeHour > 22) || (e.timeHour < 10))
            {
                Console.WriteLine("Shop closed");
            }
            else
            {
                Console.WriteLine("Shop open");
            }
        }
        ~Shop ()
        {
            mall.NotifyTime -= Close;
        }
    }
}
