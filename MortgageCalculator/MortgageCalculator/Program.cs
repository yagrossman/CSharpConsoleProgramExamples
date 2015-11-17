using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
   class Program
   {
      static void Main(string[] args)
      {
         //Get house price from user
         Console.WriteLine("Please enter the house price:");
         string inputHousePrice = Console.ReadLine();
         int housePrice = int.Parse(inputHousePrice);
      }
   }
}
