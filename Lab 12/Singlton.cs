using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Singlton
    {
        private Singlton() {}

        public static Singlton notification;

        public static Singlton Notification
        {
            get 
            { 
                if (notification == null)
                {
                    notification = new Singlton();
                }
                return notification;
            }
        }

        private static int busPlatfom = 0;
        private static int trainPlatfom = 0;

        public void Bus(int busNumber)
        {
            busPlatfom++;
            Console.WriteLine($"The bus №{busNumber} arived on platform {busPlatfom}");
        }

        public void Train(int trainNumber)
        {
            trainPlatfom++;
            Console.WriteLine($"The train №{trainNumber} arived on platform {trainPlatfom}");
        }
    }
}
