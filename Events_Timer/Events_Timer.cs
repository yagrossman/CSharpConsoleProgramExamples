using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Events_Timer
{
   class Events_Timer
   {
      static void Main(string[] args)
      {
         Timer myTimer = new Timer(2000);

         myTimer.Elapsed += MyTimer_Elapsed; //attaching MyTimer_Elapsed method to myTimer.Elapsed event
         //myTimer.Elapsed += MyTimer_Elapsed1;

         myTimer.Start();

         //Console.WriteLine("Press enter to remove the red event.");
         //Console.ReadLine();
         //myTimer.Elapsed -= MyTimer_Elapsed1;

         Console.ReadLine();
      }

      private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e) //event handler
      {
         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime); //gives down to milliseconds
      }

      private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e) //event handler
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
      }
   }
}
