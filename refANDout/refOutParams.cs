using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refANDout
{
   class refOutParams
   {
      static void Main(string[] args)
      {
         int number = 20;
         AddFive(number);
         Console.WriteLine(number);
         Console.ReadKey();
         //GreetPersons(0);
         //GreetPersons(25, "John", "Jane", "Tarzan");
         //Console.ReadKey();
      }

      static void AddFive(int number)
      {
         number = number + 5;
      }

      static void GreetPersons(int someUnusedParameter, params string[] names)
      {
         foreach (string name in names)
            Console.WriteLine("Hello, " + name);
      }
   }
}
