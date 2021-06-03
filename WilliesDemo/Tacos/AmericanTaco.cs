using MyTacoTruck.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck.Tacos
{
    public class AmericanTaco : TacoBase
    {


    public AmericanTaco(int amount = 1)
        {

            this.ShellType = new Shells("Hard", "Flour");
            this.Toppings = new Toppings("Shredded Cheese", "Hot Sauce");
            this.Protein = new Protein("Beef");
            this.Amount = amount;
    }




    }
}
