﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class ChocoFactory : IFactory
    {
        public IFood СhocolateCraft ()
        {
            return new Сhocolate() {}; 
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
