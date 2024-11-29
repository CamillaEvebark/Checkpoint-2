using System;
namespace Camilla_Mini_Project_v48
{
	public class Menu
	{
		public Menu()
		{
			
        }
        public static void PrintMenu()
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter a number for what action you want to perform: ");
            Console.WriteLine("1: Add new product");
            Console.WriteLine("2: Show sorted list with sum");
            Console.WriteLine("Q: Quit the program");
            Console.ResetColor();
        }

    }
}

