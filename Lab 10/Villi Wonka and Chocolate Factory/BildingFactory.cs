using System;
using System.Collections.Generic;
using System.Text;

namespace Villi_Wonka_and_Chocolate_Factory
{
    class BildingFactory
    {
        public IFactory Villi ()
        {
            return new ChocoFactory() { };
        }
    }
}
