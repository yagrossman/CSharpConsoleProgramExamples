using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinePerformance
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Welcome to the airline performance console application!!!");

         Console.Write("Please enter origin airport: ");
         string origin = Console.ReadLine();

         Console.Write("Please enter destination airport: ");
         string dest = Console.ReadLine();

         PrintAverageDelay(origin, dest);

         Console.ReadLine();
      }

      static void PrintAverageDelay(string origin, string dest)
      {
         int sumDelay = 0, countForAvg = 0;
         StreamReader myReader = new StreamReader("airline-on-time-performance-sep2014-us.csv");
         string line = "";

         while (line != null)
         {
            line = myReader.ReadLine();
            string[] parts = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 7) break; //to skip any invalid entries that are missing data

            if (parts[1] == origin && parts[2] == dest)
            {
               sumDelay += int.Parse(parts[4]);
               countForAvg++;
            }
         }

         int avgDelay = sumDelay / countForAvg;
         Console.WriteLine("There were {0} flights between these airports with an average delay of {1} minutes.", countForAvg, avgDelay);

         myReader.Close(); //needed to remove the reference to the file
      }
   }
}
