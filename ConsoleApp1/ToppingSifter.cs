using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ToppingSifter
    {
        public static async Task Toppings(string[] toppings)
        {

            if (toppings.Contains("Lettuce"))
            {
                Console.WriteLine("Chopping lettuce");
                await Task.Delay(3000);
                Console.WriteLine("lettuce is ready");

            }
            if (toppings.Contains("Onion"))
            {
                Console.WriteLine("Slicing Onion");
                await Task.Delay(4000);
                Console.WriteLine("Onions Sliced");
            }
            if (toppings.Contains("Steak"))
            {
                Console.WriteLine("Grilling Steak");
                await Task.Delay(6000);
                Console.WriteLine("Steak is cooked to perfection");
            }
            if (toppings.Contains("Cheese"))
            {
                Console.WriteLine("Shredding Cheese");
                await Task.Delay(3000);
                Console.WriteLine("Cheese is Shredded");
            }
            if (toppings.Contains("Guacamole"))
            {
                Console.WriteLine("Scooping Guacamole");
                await Task.Delay(4000);
                Console.WriteLine("Gaucamole prepared");
            }
             if (toppings.Contains("Cilantro"))
            {
                Console.WriteLine("Chopping Cilantro");
                await Task.Delay(2000);
                Console.WriteLine("Cilantro Ready");
            }
            if (toppings.Contains("Salsa"))
            {
                Console.WriteLine("Scooping Salsa");
                await Task.Delay(4000);
                Console.WriteLine("Salsa Drizzled over other ingredients");
            }
            if (toppings.Contains("Tomato"))
            {
                Console.WriteLine("Dicing Tomatoes");
                await Task.Delay(5000);
                Console.WriteLine("Tomatos Diced");
            }
          
            }


   

        public static async Task ProteinSifter(Taco taco)
        {
            if (taco.Protein == ("Carne Asada"))
            {
                
                Console.WriteLine("Grilling Carna Asada");
                await Task.Delay(7000);
                Console.WriteLine("Carne Asada Is Cooked");
            }
            if (taco.Protein == ("Barbacoa"))
            {
                Console.WriteLine("Stewing Barbacoa");
                await Task.Delay(8000);
                Console.WriteLine("Barbacoa Ready");
            }
            if (taco.Protein == ("Chicken"))
            {
                Console.WriteLine("Grilling Chicken");
                await Task.Delay(5000);
                Console.WriteLine("Chicken Grilled");
            }
            if (taco.Protein == ("Black Bean"))
            {
                Console.WriteLine("Scooping Black Bean");
                await Task.Delay(2000);
                Console.WriteLine("Black Beans Done");
            }
            if (taco.Protein == ("Custom"))
            {
                Console.WriteLine("Creating Custom Taco");
                await Task.Delay(10000);
                Console.WriteLine("Custom Taco is complete");
            }
        }
    }








   
    }

