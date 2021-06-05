using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class Machine
    {
        public IFood СhocolateCraft ()
        {
            return new СhocolateMachine() {}; 
        }
        public IFood СandyCraft ()
        {
            return new Candy() { };
        }
        public IFood LemonadeCraft ()
        {
            return new Lemonade() { };
        }
        public IFood IceCreamCraft ()
        {
            return new IceCream() { };
        }
    }
}
