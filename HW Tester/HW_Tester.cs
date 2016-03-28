using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
   class Program
   {
      static void Main(string[] args)
      {
         int a = 1;
         int b = 2;
         int total = 0;
         int run = 1;

         Console.WriteLine("The following are the even valued answers in the Fibonacci sequence:");

         while (total <= 4000000)
         {
            total = a + b;

            if (total % 2 == 0)
            {
               Console.WriteLine("{0}:    run #{1}, by adding {2} + {3}.", total, run, a, b);
            }

            a = b;
            b = total;
            run += 1;

         }

         Console.ReadKey();
      }
   }
}
