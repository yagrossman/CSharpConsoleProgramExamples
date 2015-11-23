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
         Card myCard = new Card("Hearts", "Ace");
         Card secondCard = new Card("Clubs", "10");
         Console.WriteLine(myCard.GetFace());
         Console.WriteLine(secondCard.GetFace());
         Console.ReadLine();

      }
   }
}
