using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = new Random().Next(1, 10); //Generate number from 1 to 9
         Console.WriteLine("Please geuss the number between 1 and 10");
         int userGuess = int.Parse(Console.ReadLine());

      }
   }
}
