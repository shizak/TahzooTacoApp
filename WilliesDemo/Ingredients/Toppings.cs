using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck.Ingredients
{
    public class Toppings
    {
        public string ToppingOneofTwo { get; set; }
        public string ToppingTwoOfTwo { get; set; }
        public Toppings(string toppingOneOfTwo = "Peppers and Onions", string toppingTwoOfTwo = "Pico de Gallo")
        {
            this.ToppingOneofTwo = toppingOneOfTwo;
            this.ToppingTwoOfTwo = toppingTwoOfTwo;
        }
    }
}
