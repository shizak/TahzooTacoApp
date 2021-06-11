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
        }
    }
}
