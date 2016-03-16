using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
   class Weekdays
   {
      public static void happyWeekend(string userInput)
      {
         DaysOfWeek myValue;
         if (System.Enum.TryParse<DaysOfWeek>(userInput, true, out myValue))
         {
            switch (myValue)
            {
               case DaysOfWeek.Sunday:
                  Console.WriteLine("Here's to the weekend! :)");
                  break;
               case DaysOfWeek.Monday:
                  break;
               case DaysOfWeek.Tuesday:
                  break;
               case DaysOfWeek.Wednsday:
                  break;
               case DaysOfWeek.Thursday:
                  break;
               case DaysOfWeek.Friday:
                  Console.WriteLine("Here's to the weekend! :)");
                  break;
               case DaysOfWeek.Saturday:
                  Console.WriteLine("Here's to the weekend! :)");
                  break;
               default:
                  break;
            }
         }
      }
   }

   enum DaysOfWeek
   {
      Sunday,
      Monday,
      Tuesday,
      Wednsday,
      Thursday,
      Friday,
      Saturday
   }
}
