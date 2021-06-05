using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Singlton.Notification.Bus(5);
            Singlton.Notification.Bus(118);
            Singlton.Notification.Train(120);
            Singlton.Notification.Bus(63);
            Singlton.Notification.Train(6325);
        }
    }
}
