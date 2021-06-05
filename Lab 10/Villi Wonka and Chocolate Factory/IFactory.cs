using System;
using System.Collections.Generic;
using System.Text;

namespace Villi_Wonka_and_Chocolate_Factory
{
    public interface IFactory
    {
        public IFood СhocolateCraft();
        public IFood СandyCraft();
        public IFood LemonadeCraft();
        public IFood IceCreamCraft();
    }
}
