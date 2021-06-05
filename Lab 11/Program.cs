using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var offisesBuilder = new OffisesBuilder();
            var blockOfFlats = new BlockOfFlatsBuilder();
            //создадим бизнес центр
            offisesBuilder.SetOffises("Morskoy");
            offisesBuilder.AddOffies(30); 
            offisesBuilder.AddOffies(2);
            offisesBuilder.AddOffies(11);
            Building Morskoy = offisesBuilder.GetBuilding();
            Console.WriteLine(Morskoy.InBuilder());

            blockOfFlats.SetBlockOfFlats("Lesnoy");
            blockOfFlats.AddSmallFlat();
            blockOfFlats.AddSmallFlat();
            blockOfFlats.AddSmallFlat();
            blockOfFlats.AddMediumFlat();
            blockOfFlats.AddMediumFlat();
            blockOfFlats.AddLargeFlat();
            blockOfFlats.AddApartament();
            blockOfFlats.AddApartament();
            Building Lesnoy = blockOfFlats.GetBuilding();
            Console.WriteLine(Lesnoy.InBuilder());
        }
    }
}
