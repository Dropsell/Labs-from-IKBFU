using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class BlockOfFlatsBuilder
    {
        private Building building = new Building("");

        public void SetBlockOfFlats(string name)
        {
            building.Name = name;
            building.Holl = 1;
        }
        public void AddSmallFlat()
        {
            building.Bedroom += 1;
            building.Kitchen += 1;
            building.Bathroom += 1; 
        }

        public void AddMediumFlat()
        {
            building.Bedroom += 2;
            building.Kitchen += 1;
            building.Bathroom += 1;
        }

        public void AddLargeFlat()
        {
            building.Bedroom += 5;
            building.Kitchen += 1;
            building.Bathroom += 2;
            building.DinnerRoom += 1;
            building.OffiesRoom += 1;
        }

        public void AddApartament()
        {
            building.Apartamet += 1;
            building.Bathroom += 1;
        }

        public Building GetBuilding()
        {
            Building result = building;
            Reset();
            return result;
        }
        public void Reset()
        {
            building = new Building("");
        }
    }
}
