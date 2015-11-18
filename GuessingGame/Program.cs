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
         for (int trys = 1; trys <= 5; trys++)
         {
            if (userGuess == number)
            {
               Console.WriteLine("You Won! Way to Go!");
               break;//no need to try again
            }
            else
            {
               Console.WriteLine("Sorry, Press Enter to try Again. You have:" + (5 - trys) + "left.");
               Console.ReadLine();
            }
         }

      }
   }
}
