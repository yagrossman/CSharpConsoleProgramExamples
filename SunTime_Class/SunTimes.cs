using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
   public class SunTimes
   {
      DateTime SunriseTime;
      DateTime SunsetTime;
      
      public SunTimes(DateTime sunrise, DateTime sunset)
      {
         SunriseTime = sunrise;
         SunsetTime = sunset;
      }

      public TimeSpan DaylightMinutes()
      {
         TimeSpan dayMinutes;
         dayMinutes = SunsetTime - SunriseTime;

         return dayMinutes;
      }
   }
}
