using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiplesOfThreeAndFive
{
   class Program
   {
      static void Main(string[] args)
      {
         int sum = 0;
         //loops throught all natural numbers below one thousand
         for (int i = 0; i < 1000; i++)
         {
            //if the current number is a multiple of three it is added to the sum
            if (i % 3 == 0)
            {
               sum += i;
            }
            //if the current number is a multiple of five it is added to the sum
            else if (i % 5 == 0)
            {
               sum += i;
            }
         }
         Console.WriteLine(sum);
         Console.ReadLine();
      }
   }
}
