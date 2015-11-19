using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppExample
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] catalog = ReadCatalogFromFile();
         string[] cart = new string[5];
         Console.WriteLine("***Welcome to this Shopping App, enter 5 products one by one to fill up cart.***");
         int positionCart = 0;
         while (cart[4]==null)
         {
            Console.Write("Enter a product to place in cart: ");
            string inputProduct = Console.ReadLine();
            if(IsProductInCatalog(inputProduct, catalog) == true)
            {
               cart[positionCart] = inputProduct;
               Console.WriteLine("$$$ "+inputProduct+" has been added to your cart");
               positionCart++;
            }
            else
            {
               Console.WriteLine("Sorry, " + inputProduct + " is not in catalog. Try another Product.");
            }
         }
         Console.WriteLine("***You're ready to check out! Here are the products in your shopping cart:***");
         for (int i = 0; i < 5; i++)
         {
            Console.WriteLine(cart[i]);
         }
         Console.ReadLine();
      }

      //reads catalog file into an array
      static string[] ReadCatalogFromFile()
      {
         StreamReader input = new StreamReader("catalog.txt");
         string[] catalog = new string[200];
         string line = "";
         for (int i = 0; i < 200; i++)
         {
            line = input.ReadLine();
            if (line == null) break;
            catalog[i] = line;
         }
         return catalog;
      }

      static bool IsProductInCatalog(string product, string[] catalog)
      {
         foreach(string match in catalog)
         {
            if (product == match)
               return true;
         }
         return false;
      }

   }
}
