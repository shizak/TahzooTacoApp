using MyTacoTruck.Tacos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTacoTruck
{
    public static class UserInterface
    {
        public  const string newLine = "\n";
        public  const string doubleNewLine = "\n\n";
        public static void RunInitialInterface()
        {

            Greeting();


            Console.ReadLine();


        }
        public static void Greeting()
        {
            Console.WriteLine("Hey There! Welcome To TAHZOO TACOS!");
            Console.WriteLine(newLine);
            Console.WriteLine("What Would You Like To Do?");
            Console.WriteLine(doubleNewLine);

            InitialQuestion();
        }

        public static void InitialQuestion()
        {
            Console.WriteLine("A: Order");
            Console.WriteLine("B: See The Menu");
            AnswerForInitialQuestion();
        }



        public static void ErrorChoicePrompt()
        {
            Console.WriteLine("Sorry Please Try typing in your answer again");
        }

        public static void ErrorNumberPrompt()
        {
            Console.WriteLine("Sorry Please Try typing in your answer again, this time using the number keys");
        }

        public static void AnswerForInitialQuestion()
        {
            string answerIQ = Console.ReadLine();
            answerIQ = answerIQ.ToUpper();
           
            if(answerIQ == "A" || answerIQ == "B")
            {
                if(answerIQ == "A")
                {
                    Console.Clear();
                    PlaceOrder();
                } else
                {
                    ShowMenu();
                }
                
                
            } else
            {
                Console.Clear();
                ErrorChoicePrompt();
                Console.WriteLine(newLine);
                Greeting();
                
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            
            Console.WriteLine("         Menu");

            Console.WriteLine(doubleNewLine);

            Console.WriteLine("Traditional Taco:");
            Console.WriteLine("Soft, Corn based Tortilla with Carnitas, Peppers and Onions, and Pico de Gallo");

            Console.WriteLine(newLine);

            Console.WriteLine("American Taco:");
            Console.WriteLine("Hard, Flour Tortilla with Beef, Shredded Cheese, and Hot Sauce");

            Console.WriteLine(doubleNewLine);

            Console.WriteLine("Please enter \"A\" when you are ready to go back");
            Console.WriteLine(newLine);

            string readyToReturn = Console.ReadLine();
            readyToReturn = readyToReturn.ToUpper();

            if(readyToReturn == "A")
            {
                Console.Clear();
                Greeting();
            } else
            {
                ErrorChoicePrompt();
                Console.Clear();
                ShowMenu();
            }

        }

        public static void PlaceOrder()
        {
            

            Console.WriteLine(newLine);

            Console.WriteLine("What Can We Make For You Today?");

            Console.WriteLine(newLine);

            Console.WriteLine("A: Traditional Tacos");
            Console.WriteLine("B: American Tacos");
            Console.WriteLine("C: Both");

            string orderType = Console.ReadLine();
            orderType = orderType.ToUpper();

            if (orderType == "A" || orderType == "B" || orderType == "C")
            {
             
                switch (orderType)
                {
                    case "A":
                        Console.Clear();
                        int amountofTraditional = AmountOfTacosOneType("Traditional");
                        OrderProcessingPrompt();
                        CookTraditonalTaco(amountofTraditional);
                        break;
                    case "B":
                        Console.Clear();
                        int amountofAmerican = AmountOfTacosOneType("American");
                        OrderProcessingPrompt();
                        CookAmericanTaco(amountofAmerican);
                        break;
                    case "C":
                        Console.Clear();
                        int amountofTraditionalBoth = AmountOfTacosOneType("Traditional");
                        int amountofAmericanBoth = AmountOfTacosOneType("American");
                        OrderProcessingPrompt();
                        CookBothKindsOfTaco(amountofAmericanBoth, amountofTraditionalBoth);
                        break;
                    default:
                        break;
                }
            } else {



                Console.Clear();
                ErrorChoicePrompt();
                Console.WriteLine(newLine);
                PlaceOrder();
                
                
                
            }

        }

        public static int AmountOfTacosOneType(string typeOfTaco)
        {

       
                Console.WriteLine($"How Many {typeOfTaco} tacos Would you like?");
                Console.WriteLine("e.g. \"3\"");
                Console.WriteLine(newLine);



                bool resultOneType;
                int amountWantedIntOneType;
                string amountWantedStringOneType = Console.ReadLine();
                resultOneType = int.TryParse(amountWantedStringOneType, out amountWantedIntOneType);




                if (resultOneType == true && amountWantedIntOneType > 0)
                {

                    return amountWantedIntOneType;

                }
                else
                {
                    Console.Clear();
                    ErrorNumberPrompt();
                    Console.WriteLine(newLine);
                    AmountOfTacosOneType(typeOfTaco);
                    return 0;


                }
            
        }

        public static void CookAmericanTaco(int amount)
        {
            AmericanTaco myTaco = new(amount);
            Processor.CookTheOrder(myTaco);
        }

        public static void CookTraditonalTaco(int amount)
        {
            TraditionalTaco myTaco = new(amount);
            Processor.CookTheOrder(myTaco);
        }

        public static void CookBothKindsOfTaco(int amountA, int amountT)
        {
            AmericanTaco myTacoA = new(amountA);
            TraditionalTaco myTacoT = new(amountT);
            Processor.CookTheOrder(myTacoA);
            Processor.CookTheOrder(myTacoT);
        }

        public static void OrderProcessingPrompt()
        {
            Console.Clear();
            Console.WriteLine("ORDER PROCESSING...");
            Console.WriteLine(doubleNewLine);
        }
    }


}







