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
         }
         return catalog;
      }


   }
}
