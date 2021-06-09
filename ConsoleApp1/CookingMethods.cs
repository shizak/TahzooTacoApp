
using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CookingMethods
    {
        //Onion,Tomato,Guacamole,Cheese,Salsa,Cilantro

        //Carne Asada:Onion,Guacamole,Cilantro
        //Barbacoa:Onion,Guacamole,Cilantro
        //Chicken:Onion,Tomato,Cheese,Salsa
        //Black Bean:Onion,Tomato,Guacamole,Cheese
        //Custom:Onion,Tomato,Guacamole,Cheese,Salsa,Cilantro


        public static async Task CookTheTacos(ArrayList taco)
        {

           
            foreach (var item in taco) // instead of foreach, I will have to call CookTheTacos on each taco in the list
                // because right now they are basically executing syncrohnously. This is doable but will take sometime
                // idk if this is the right direction to go
            {
                Taco t = (Taco)item;
                Console.WriteLine($"Heating up the skillet for the {t.Protein} tacos");
                await Task.Delay(2000);
                Console.WriteLine($"{t.Protein} in the skillet");
                await Task.Delay(5000);

            }
  


        }






    }
}
