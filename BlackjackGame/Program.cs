using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Welcome to Blackjack! Press any key to begin game.");
         Console.ReadKey();
         Game myGame = new Game();
         myGame.ComputerMove();
         myGame.ComputerMove();
         while (myGame.ComputerScore < 17)
         {
            myGame.ComputerMove();
         }
         myGame.GameWinCheck();
         myGame.UserMove();
         myGame.UserMove();
         myGame.GameWinCheck();
         while (true)
         {
            Console.WriteLine("Would you like to draw another card (Y/N)?");
            if (Console.ReadLine().ToUpper() == "Y")
            {
               myGame.UserMove();
               myGame.GameWinCheck();
            }
            else
            {
               if (myGame.ComputerScore > myGame.UserScore)
               {
                  Console.WriteLine("GAME OVER \n The house has {0} points, you have {1} points.", myGame.ComputerScore, myGame.UserScore);
                  Console.WriteLine("The house always wins in the end! ;)");
               }
            }
            myGame.ComputerMove();
            myGame.GameWinCheck();
         }
      }
   }
}
