﻿using System;
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
         Console.WriteLine("Ready to Play??? :) Guess the number between 1 and 10");
         //int userGuess = int.Parse(Console.ReadLine());
         for (int attempt = 1; attempt <= 5; attempt++)
         {
            if (attempt > 1)
            {
               Console.WriteLine("Sorry, You have: " + (5 - attempt) + " attempts left.");
               Console.WriteLine("Enter a number between 1 and 10 to try again.")
            }
            int userGuess = int.Parse(Console.ReadLine());
            if (userGuess == number)
            {
               Console.WriteLine("You Won! Way to Go!");
               break;//no need to try again
            }
         }

      }
   }
}
