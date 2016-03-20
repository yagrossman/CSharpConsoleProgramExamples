using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   class Program
   {
      static void Main(string[] args)
      {
         int num1 = 1;
         int num2 = 2;
         int ttl = num2;

         while (num2 <= 4000000)
         {
            int temp = num2;
            num2 += num1;
            num1 = temp;

            if (num2 % 2 == 0)
            {
               ttl += num2;
            }

         }

         Console.WriteLine(ttl);
         Console.ReadKey();
      }
   }
}


