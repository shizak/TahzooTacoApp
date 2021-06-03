using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck.Ingredients
{
    public class Shells
    {
        public string Hardness { get; set; }
        public string Style { get; set; }


        public Shells(string hardness = "soft", string style = "corn")
        {
            this.Hardness = hardness;
            this.Style = style;
        }





    }
}
