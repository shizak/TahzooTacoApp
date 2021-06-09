using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class UI
    {



         

            public static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Menu");
                Console.WriteLine("2) Order");
                Console.WriteLine("3) Exit");
                Console.Write("\r\nSelect an option: ");
                ArrayList tacoOrder = new ArrayList();

                switch (Console.ReadLine())
                {
                    case "1":
                        Menu();
                        return true;
                    case "2":
                        Order(tacoOrder);

                        return true;
                    case "3":
                        return false;
                    default:
                        return true;
                }
            }



            private static void Menu()
            {
                Console.Clear();

                StreamReader reader = File.OpenText("menu.txt"); // Shows individual menu items -
                                                                 // can be found in the debug folder for this portion of the project along with all of the other txt files
                string line;
                while ((line = reader.ReadLine()) != null)  // returns null when at the end of the file i think
                {
                    string[] items = line.Split('\n'); // creates an Items array from what it seperates from the string Line at "\n" instances

                    foreach (string item in items)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.WriteLine("\nPress Enter to go back");  //  Works good because it doesnt mater what i press, it only resolves if i hit enter
                Console.ReadLine();

            }

            private static int StrToInt(string str) //used a lot on the Order method for brevity
            {
                int x = 0;
                try
                {
                    x = Int32.Parse(str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Bad Format", str);

                }
                return x;
            }

            private static ArrayList Order(ArrayList tacoOrder)
            {

                ArrayList typeTaco = new ArrayList();
                StreamReader reader = File.OpenText("taco_proteintoppings.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split(':');
                    Taco t = new Taco(items[0], items[0], items[1], "");
                    typeTaco.Add(t);

                }
                Console.Clear();

                int count = 0;
                foreach (Taco item in typeTaco)
                {
                    count++;
                    Console.WriteLine(String.Format(count + ". " + item.Protein + " Taco {0,5}$2.50" + "\n\n", "\t\t"));
                    // these are all formating and style things {0,5} adds spaces - \n is a line space - \t is a format space

                }

                Console.WriteLine("Choose number from Menu above to Order");
                string order_str = Console.ReadLine();
                int order = StrToInt(order_str);

                if (order == count)
                {
                    Console.WriteLine("Quantity: ");
                    string q = Console.ReadLine();
                    int quantity_int = StrToInt(q);

                    for (int i = 0; i < quantity_int; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("Protein:");
                        for (int j = 0; j < typeTaco.Count - 1; j++)
                        {
                            Taco t = (Taco)typeTaco[j];
                            Console.WriteLine((j + 1) + ". " + t.Protein + "\n");
                        }
                        Console.WriteLine("Enter number to choose protein");

                        string order_protein = Console.ReadLine();
                        int protein_int = StrToInt(order_protein);

                        Console.Clear();
                        Taco t2 = (Taco)typeTaco[typeTaco.Count - 1];
                        string[] topping_list = t2.Topping.Split(",");

                        for (int j = 0; j < topping_list.Length; j++)
                        {
                            Console.WriteLine((j + 1) + ". " + topping_list[j] + "\n");
                        }

                        Console.WriteLine("Number of Toppings - 6 max:"); // have to limit this to 6 ////
                        string numTop = Console.ReadLine();
                        int numToppings = StrToInt(numTop);

                        if (numToppings > 6) // validation of numToppings
                    {
                        numToppings = 6;
                    } else if (numToppings < 1)
                    {
                        numToppings = 1;
                    } // end of validation for numToppings//

                        Console.WriteLine("\nEnter number to choose topping");
                        string topping = "";

                        for (int j = 0; j < numToppings; j++) // limit the number of toppings to 6
                        {
                            Console.WriteLine("Topping #" + (j + 1));
                            string topping_input_str = Console.ReadLine();
                            int topping_input = StrToInt(topping_input_str);
                            topping = topping + topping_list[topping_input - 1] + ", ";
                        }
                        topping = topping.Remove(topping.Length - 2);
                        Taco p = (Taco)typeTaco[protein_int - 1];
                        string time = DateTime.Now.ToString("h:mm:ss tt");
                        Taco t1 = new Taco("Custom", p.Protein, topping, time);
                        tacoOrder.Add(t1);
               
                   
                    }
                }
                else
                {
                    string q_str;


                    Console.WriteLine("Quantity: ");
                    q_str = Console.ReadLine();
                    int q_int = StrToInt(order_str);

                    for (int i = 0; i < q_int; i++)
                    {
                        string time = DateTime.Now.ToString("h:mm:ss tt");
                        Taco t = (Taco)typeTaco[order - 1];
                        t.Time = time;
                        tacoOrder.Add(t);
                   
                }
                }


                Receipt(tacoOrder);

                Console.WriteLine("\nAdd to Order? (Y/N)");  // Add answer.toUpper() and check for other mistakes

                string answer = Console.ReadLine();

                if (answer == "Y")
                {
                    Order(tacoOrder);
                }
                else
                {
                    Console.Clear();
                    CookingMethods.CookTheTacos(tacoOrder);
                Console.ReadLine();
                }

            return tacoOrder;
            }

            private static void Receipt(ArrayList tacoOrder)
            {
                Console.Clear();

                Console.WriteLine("Receipt");
                foreach (var item in tacoOrder)
                {
                    Taco t = (Taco)item;
                    Console.WriteLine(t.Type + "\t\t\t$2.50");
                    Console.WriteLine("\tProtein: " + t.Protein);
                    Console.WriteLine("\tToppings: " + t.Topping);
                    Console.WriteLine("\tTime:" + t.Time);

                }
                Console.WriteLine("Total\t\t\t{0:C}", tacoOrder.Count * 2.50);


               

            }

        }
    }

