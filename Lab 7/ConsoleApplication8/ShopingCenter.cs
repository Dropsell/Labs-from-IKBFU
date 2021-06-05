using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class ShopingCenter
    {
        public event EventHandler<TrahHolderEventArgs> NotifyTime;

        private int timeHour;

        public int getTimeHour() 
            {
                return timeHour;
            }
        public void setTimeHour(int newTimeHour)
        {
                if (newTimeHour >= 24)
                {
                    newTimeHour -= 24;
                }
                timeHour = newTimeHour;
                Console.WriteLine($"Now Time {timeHour}");
                NotifyTime?.Invoke(this, new TrahHolderEventArgs { timeHour = timeHour });
        }
    }

     public class TrahHolderEventArgs : EventArgs
    {
        public int timeHour { get; set;}
    } 
}
