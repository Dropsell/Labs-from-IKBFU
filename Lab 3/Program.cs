using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void StatusOfStudent (People student)
        {
            switch (student.GetProgram())
            {
                case programEducation.PM:
                    Console.WriteLine("Bad");
                    break;
                case programEducation.MO:
                    Console.WriteLine("Very Bad");
                    break;
                default:
                    Console.WriteLine("Very Very Bad");
                    break;


            }
        }
        static void Main(string[] args)
        {
            var me = new People();
            //me.SetName ("Viktor");
            me.Name = "Viktor";
            me.Age = 18;
            me.Entrance("IKBFU", programEducation.MO);
            Console.WriteLine("Name {0}, Age {1}, University {2}, Programm {3}", me.Name, me.Age, me.GetUnversity(), me.GetProgram());
            StatusOfStudent(me);
            var friend = new People();
            me.Name = "NoName";
            me.Age = 7;
            me.Entrance("IKBFU", programEducation.PM);
            Console.WriteLine("Name {0}, Age {1}, University {2}, Programm {3}", me.Name, me.Age, me.GetUnversity(), me.GetProgram());
            StatusOfStudent(friend);
            Console.ReadKey();
        }
    }
}
