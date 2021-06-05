using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Building
    {
        public Building (string name)
        {
            Name = name;
            Holl = 0;
            OffiesRoom = 0;
            Kitchen = 0;
            DinnerRoom = 0;
            Bathroom = 0;
            Apartamet = 0;
            Bedroom = 0;
        }
        public string Name { get; set; }
        public int Holl { get; set; }
        public int OffiesRoom { get; set; }
        public int Kitchen { get; set; }
        public int DinnerRoom { get; set; }
        public int Bathroom { get; set; }
        public int Apartamet { get; set; }
        public int Bedroom { get; set; }
        public string InBuilder()
        {
            string outStr = "";
            outStr = "In " + Name + " building: ";
            if (Holl > 0)
            {
                outStr += Holl.ToString() + " Holl, ";
            }
            if (OffiesRoom > 0)
            {
                outStr +=  OffiesRoom.ToString() + " Offies Rooms, ";
            }
            if (Kitchen > 0)
            {
                outStr += Kitchen.ToString() + " Kitchens, ";
            }
            if (DinnerRoom > 0)
            {
                outStr += DinnerRoom.ToString() + " DinnerRoom, ";
            }
            if (Bathroom > 0)
            {
                outStr += Bathroom.ToString() + " Bathroom, ";
            }
            if (Apartamet > 0)
            {
                outStr += Apartamet.ToString() + " Apartamet, ";
            }
            if (Bedroom > 0)
            {
                outStr += Bedroom.ToString() + " Bedroom.";
            }
            return outStr;
        } 
    }
}
