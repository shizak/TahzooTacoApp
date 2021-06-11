
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



// Need to sift through order so we know how many of each taco are in the order
// then we can send those numbers to the CookTheTacosAsync Method along with the order
// then each type of taco would only be cooked once
// but would log out - Cooking Cilantro for "4" tacos
// instead of printing Cooking Cilantro 4 times

        public static async Task CookTheTacosAsync(ArrayList tacos) 
        {
            string[] myArr = new string[] { };

            foreach (var item in tacos)// splits the order up and takes ingreidsnt string -parses and pushes them to an array
            // to be passed off and cooked
            {
                Taco t = (Taco)item;

                string phrase = t.Topping;
                string[] words = phrase.Split(',');
                myArr = myArr.Concat(words).ToArray();
                //Console.WriteLine(t);
                CookIndividualAsync(t, words);

            }

            
        }



        public static async Task CookIndividualAsync(Taco taco, string[] toppingsArr)
        {
        
             ToppingSifter.Toppings(toppingsArr);
             await ToppingSifter.ProteinSifter(taco);
            
            await Task.Delay(5000);
            Console.WriteLine("Assembling and Pacakaging the taco");
            await Task.Delay(7000);
            Console.WriteLine("\n Your Taco Is Ready!");
        }

        public static void SendOffMessage()
        {

        }

    }
}
