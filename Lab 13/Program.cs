using System;

namespace Lab_13
{
    class Program
    {
        static void Cout (Tram tram)
        {
            Console.WriteLine($"{tram.tramId.tramNumber}: line {tram.LineNumber}, driver {tram.Driver}");
        }
        
        static void Main(string[] args)
        {
            var tram1 = new Tram(2001);
            tram1.LineNumber = 5;
            tram1.Driver = "Steve";
            var tram2 = tram1.ShallowCopy();
            var tram3 = tram1.DeepCopy();

            Cout(tram1);
            Cout(tram2);
            Cout(tram3);

            tram1.tramId.tramNumber = 2101;
            tram1.LineNumber = 2;
            tram1.Driver = "John";

            Cout(tram1);
            Cout(tram2);
            Cout(tram3);

        }
    }
}
