using MyTacoTruck.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck.Tacos
{
    public class TraditionalTaco : TacoBase
    {


        public TraditionalTaco(int amount)
        {

            this.ShellType = new Shells("Soft", "Corn");
            this.Toppings = new Toppings("Peppers and Onions", "Pico de Gallo");
            this.Protein = new Protein("Carnitas");
            this.Amount = amount;
        }


    }
}
