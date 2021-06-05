using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class OffisesBuilder
    {
        private Building building = new Building("");
        
        public void SetOffises (string name)
        {
            building.Name = name;
            building.Bathroom = 1;
            building.Holl = 1;
        }
        public void AddOffies (int rooms)
        {
            building.OffiesRoom += rooms;
            building.Bathroom += rooms / 5; // на каждые пять комнат делаем дополнительный туалет
            building.DinnerRoom += rooms / 10; // на каждые 10 комнат делаем дополнительную зону для перекуса
        }

        public Building GetBuilding ()
        {
            Building result = building;
            Reset();
            return result;
        }
        public void Reset ()
        {
            building = new Building("");
        }
    }
}
