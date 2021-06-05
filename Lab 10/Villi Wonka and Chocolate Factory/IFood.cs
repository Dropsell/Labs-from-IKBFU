using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Villi_Wonka_and_Chocolate_Factory
{
    public interface IFood
    {
        public string CookNum { get; set; }
        public void Cook(string CookNum);
    }
}
