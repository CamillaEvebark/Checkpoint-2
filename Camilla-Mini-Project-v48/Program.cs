using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Camilla_Mini_Project_v48;

namespace Camilla_Mini_Project_v48
{
    class Program
    {
        static void Main(string[] args)
        {

            bool addMore = true;
            
            List<Product> productList = new List<Product>();

            while (addMore)
            {
                Menu.PrintMenu();

                switch (Simplify(Console.ReadLine()))

                {
                    case "1":

                        AddProductInCategory(productList);
                        break;

                    case "2":

                        PrintList(productList);
                        break;

                    case "Q":
                        PrintList(productList);
                        Console.WriteLine("Thank you for visiting!");
                        addMore = false;
                        break;
                }
            }
        }

        private static void AddProductInCategory(List<Product> productList)
        {
            while(true) { 
                
                Product product = new Product();

                Console.Write("Type in the category: ");
                product.Category = Console.ReadLine();

                Console.WriteLine("Type in the product name:");
                product.Name = Console.ReadLine();

                Console.WriteLine("Type in the price in following format 0.00:");
                product.Price = Convert.ToDouble(Console.ReadLine());

                // Add the product object to the product list
                productList.Add(product);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Product added!");
                Console.ResetColor();

                Console.WriteLine("Would you like to add more products? Y/N");
                
                if (Simplify(Console.ReadLine()) == "N")
                {
                    break;
                }
            }

            //List products
            Console.WriteLine("Here is the list of products you have currently added:");
            PrintList(productList);
        }

        public static string Simplify(string input)
        {
            return input.Trim().ToUpper();
        }

        public static void PrintList(List<Product> productList)
        {
            List<Product> SortedList = productList.OrderBy(p => p.Price).ToList();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Category\tProduct\t\tPrice");
            foreach (Product product in SortedList)
            {
                Console.WriteLine(product.Category + "\t\t" + product.Name + "\t\t" + product.Price);
                Console.WriteLine();

            }
            Console.WriteLine("Total sum is: " + SortedList.Sum(p => p.Price));
        }
    }
}





