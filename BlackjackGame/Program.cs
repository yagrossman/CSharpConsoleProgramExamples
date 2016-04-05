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
         if (myGame.GameWinCheck())
         {
            Console.WriteLine("Press any key to exit.");
            Environment.Exit(1);
         }
         myGame.UserMove();
         myGame.UserMove();
         while (myGame.GameWinCheck() == false)
         {
            Console.WriteLine("Would you like to draw another card (Y/N)?");
            if (Console.ReadLine().ToUpper() == "Y")
            {
               myGame.UserMove();
               if (myGame.GameWinCheck())
               {
                  Console.WriteLine("Press any key to exit.");
                  Environment.Exit(1);
               }
            }

               
         }
         myGame.ComputerMove();
         myGame.UserMove();

         Console.ReadLine();

      }
   }
}
