using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck.Ingredients
{
    public class Protein
    {
        public string TypeOfProtein { get; set; }


        public Protein( string typeOfProtein = "Carnitas")
        {
            this.TypeOfProtein = typeOfProtein;
        }
    }
}
