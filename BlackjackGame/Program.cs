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
         Deck myDeck = new Deck();
         Card card1 = myDeck.DrawCard();
         Console.WriteLine(card1.GetFace());
         Console.WriteLine(myDeck.DrawCard().GetFace());
         Console.WriteLine("for loop");
         for (int i = 0; i < 52; i++)
         {
            Console.WriteLine(myDeck.DrawCard().GetFace());
         }
         Console.ReadLine();

      }
   }
}
