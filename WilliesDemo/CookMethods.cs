using MyTacoTruck.Ingredients;
using MyTacoTruck.Tacos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck
{
    class CookMethods
    {

       
        public static async Task<Shells> HeatShellsAsync(TacoBase taco)
        {

            
            Console.WriteLine($"Warming the pan for the {taco.ShellType.Hardness} {taco.ShellType.Style} Shells");
            await Task.Delay(3000);
            Console.WriteLine($"{taco.ShellType.Hardness} {taco.ShellType.Style} Shells in the pan");
            await Task.Delay(4000);


            return new Shells();

            // need to make an if else for if the hells are hard, they should not go in a paan, they should go in the oven
        }



        public static async Task<Toppings> PrepareToppings(TacoBase taco)
        {
            if (taco is AmericanTaco)
            {
                Console.WriteLine($"Grating and Measuring the {taco.Toppings.ToppingOneofTwo}");
                Console.WriteLine($"Making sure the {taco.Toppings.ToppingTwoOfTwo} is nice and spicy");
                await Task.Delay(7000);
                
                await Task.Delay(2000);


                return new Toppings();
            }
            else
            {
                Console.WriteLine($"Heating up the wok for the {taco.Toppings.ToppingOneofTwo}");
                Console.WriteLine($"Preparing the perfect amount of {taco.Toppings.ToppingTwoOfTwo}");
                await Task.Delay(2000);
                Console.WriteLine($"{taco.Toppings.ToppingOneofTwo} in the wok");
                await Task.Delay(5000);


                return new Toppings();
            }

        }





        public static async Task<Protein> CookProtein(TacoBase taco)
        {
            Console.WriteLine($"Heating up the skillet for the {taco.Protein.TypeOfProtein}");
            await Task.Delay(2000);
            Console.WriteLine($"{taco.Protein.TypeOfProtein} in the skillet");
            await Task.Delay(5000);


            return new Protein();
        }




    }
}
