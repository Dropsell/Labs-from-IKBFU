using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Cinema
    {
        private ShopingCenter mall;
        public Cinema(ShopingCenter newMall)
        {
            mall = newMall;
            mall.NotifyTime += Close;
        }
        public void Close(object sender, TrahHolderEventArgs e)
        {
            if (e.timeHour < 10)
            {
                Console.WriteLine("Cinema closed");
            }
            else
            {
                Console.WriteLine("Cinema open");
            }
        }
        ~Cinema()
        {
            mall.NotifyTime -= Close;
        }
    }
}
