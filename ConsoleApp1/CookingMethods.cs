﻿
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


        public static async Task CookTheTacos(ArrayList tacos)
        {


            foreach (var item in tacos)
            {
                Taco t = (Taco)item;

                string phrase = t.Topping;
                string[] words = phrase.Split(',');

                //Console.WriteLine(t);
                CookIndividual(t, words);

            }
        }



        public static void CookIndividual(Taco taco, string[] toppingsArr)
        {
        
            ToppingSifter.Toppings(toppingsArr);
            ToppingSifter.ProteinSifter(taco);
 
        }


    }
}
