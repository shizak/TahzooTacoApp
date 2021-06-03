using MyTacoTruck.Tacos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyTacoTruck.CookMethods;

namespace MyTacoTruck
{
    public static class Processor
    {


        public static async Task CookTheOrder(TacoBase myTaco)
        {

            Task shellsTask = HeatShellsAsync(myTaco);
            Task toppingsTask = PrepareToppings(myTaco);
            Task proteinTask = CookProtein(myTaco);
            
            var breakfastTasks = new List<Task> { shellsTask, toppingsTask, proteinTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == shellsTask)
                {
                    Console.WriteLine($"Put shells on plate");
                } else if (finishedTask == toppingsTask)
                {
                    Console.WriteLine($"{myTaco.Toppings.ToppingTwoOfTwo} has been delicately drizzled all over taco");
                    Console.WriteLine($"Sprinkling the {myTaco.Toppings.ToppingOneofTwo} all over the taco ");
                } else if (finishedTask == proteinTask)
                {
                    Console.WriteLine($"{myTaco.Protein.TypeOfProtein} Done");
                }

                breakfastTasks.Remove(finishedTask);
            }
            Console.WriteLine("ORDER UP!!!");
            Console.WriteLine("\n\n");
            Console.WriteLine("Your Order is ready!");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("HAVE A NICE DAY!");
        }

    }




}
