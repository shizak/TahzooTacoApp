using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Taco
    {
        public string Type { get; set; }
        public string Protein { get; set; }
        public string Topping { get; set; }
        public string Time { get; set; }
        public Taco(string type, string protein, string topping, string time)
        {
            Type = type;
            Protein = protein;
            Topping = topping;
            Time = time;

        }
    }
}
