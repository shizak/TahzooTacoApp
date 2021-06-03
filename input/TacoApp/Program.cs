using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace StringManipulation
{
    class Program
    {

        public class Taco
        {
            public string Type { get; set; }
            public string Protein { get; set; }
            public string Topping { get; set; }
            public string Time { get; set; }
            public Taco(string type, string protein, string topping, string time)
            {
                Type = type;
                Protein = protein;
                Topping = topping;
                Time = time;

            }
        }
        public static void Main(string[] args)
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
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

            StreamReader reader = File.OpenText("menu.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split('\n');

                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\nPress Enter to go back");
            Console.ReadLine();

        }

        private static int StrToInt(string str)
        {
            int x=0;
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

                    Console.WriteLine("Number of Toppings:");
                    string numTop = Console.ReadLine();
                    int numToppings = StrToInt(numTop);

                    Console.WriteLine("\nEnter number to choose topping");
                    string topping = "";

                    for (int j = 0; j < numToppings; j++)
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


            Console.WriteLine("\nAdd to Order? (Y/N)");

            string answer = Console.ReadLine();

            if (answer == "Y")
            {
                Order(tacoOrder);
            }

        }

    }
}