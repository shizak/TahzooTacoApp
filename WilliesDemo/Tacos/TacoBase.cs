using MyTacoTruck.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck.Tacos
{
    public class TacoBase
    {
        public Shells ShellType { get; set; }
        public Toppings Toppings { get; set; }
        public Protein Protein { get; set; }

        public int Amount { get; set; }





    }
}
