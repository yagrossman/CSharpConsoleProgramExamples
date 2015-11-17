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
         Console.WriteLine("Please enter duration of mortgage:");
         int years = int.Parse(Console.ReadLine());
         Console.WriteLine("Please enter yearly interest rate, in percentage");
         int interestPercent = int.Parse(Console.ReadLine());

         double interestRate = 1 + (interestPercent / 100.0);

         double total = housePrice * Math.Pow(interestRate, years);

         Console.WriteLine("Your mortgage will be: " + total);

         Console.ReadLine();
      }
   }
}
