using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {


            
                bool showMenu = true;

                while (showMenu)
                {
                    showMenu = UI.MainMenu(); // will return true or false based on switch value in MainMenu Method
                }
            


            //Console.WriteLine("Hello World!");

            //List<string> myList = Toppings(toppings, 5);
            //Console.WriteLine("\n");

            //LogInstructions(myList);

            //Console.ReadLine();
        }

        static string[] toppings = { "Lettuce", "Onion", "Steak", "Cheese" }; //Simulation of what comes on a taco

        public static List<string> Toppings(string[] toppings, int tacoTime) {


            List<string> instructions = new List<string>(); //Log Process of taco Send to William
            List<int> instructionsTime = new List<int>(); //Time it takes -> Send to William  

            //int tacoTime = 0; //How long does the taco take -> Send to Shiza

            if (toppings.Contains("Lettuce")) {
              instructions.Add("Chopping lettuce");
              instructionsTime.Add(10);
              //instructions.ToList().ForEach(Console.WriteLine);
              tacoTime += 10;
            }
            if (toppings.Contains("Onion")) {
              instructions.Add("Slicing Onion");
              instructionsTime.Add(10);
              //instructions.ToList().ForEach(Console.WriteLine);
              tacoTime += 10;
            }
            if (toppings.Contains("Steak")) {
              instructions.Add("Grilling Steak");
              instructionsTime.Add(30);
              //instructions.ToList().ForEach(Console.WriteLine);
              tacoTime += 30;
            }
            if (toppings.Contains("Cheese")) {
              instructions.Add("Shredding Cheese");
              instructionsTime.Add(5);
              //instructions.ToList().ForEach(Console.WriteLine);
              tacoTime += 5;
            }
                    //Console.WriteLine(tacoTime);Test Statement
                    //instructions.ToList().ForEach(Console.WriteLine); Test Statement 
                    //instructionsTime.ToList().ForEach(Console.WriteLine); Test Statement
                    Console.WriteLine(tacoTime);
            return instructions;
    }

        
        public static void LogInstructions(List<string> instructionList)
        {
            foreach (var item in instructionList)
            {
                Console.WriteLine(item);
                Console.WriteLine("\n");

               
            }
        }


    }
}
