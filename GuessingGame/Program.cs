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
         //int userGuess = int.Parse(Console.ReadLine());
         for (int @try = 1; @try <= 5; @try++)
         {
            if(@try>1)Console.WriteLine("Try Again, enter a number between 1 and 10");
            int userGuess = int.Parse(Console.ReadLine());
            if (userGuess == number)
            {
               Console.WriteLine("You Won! Way to Go!");
               break;//no need to try again
            }
            else
            {
               Console.WriteLine("Sorry, Press Enter to try Again. You have: " + (5 - @try) + "tries left.");
               Console.ReadLine();
            }
         }

      }
   }
}
