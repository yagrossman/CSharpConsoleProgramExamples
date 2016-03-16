using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace FlightPreformance
{
   class AirlineClass
   {
      //this class will be used to store and access data the necessary for each airline
      public String AirlineName { get; set; }
      public int FlightCounter { get; set; }
      public int SumArrivalDelays { get; set; }
      public int MaxArrivalDelay { get; set; }
      public int MaxDepartureDelay { get; set; }
      public int SumDepartureDelays { get; set; }
   }

   class Program
   {
      public static void printAverageDelay(string origin, string destination)
      {
         try
         {
            //creates an array list of airlineClass objects to store data of multiple airlines
            ArrayList airlinesList = new ArrayList();
            StreamReader myReader = new StreamReader("airline-on-time-performance-sep2014-us.csv");
            string line;
            int arrivalDelays = 0;
            int departureDelays = 0;
            //loops the entire file of airline data
            while ((line = myReader.ReadLine()) != null)
            {
               //splits each line in the file into elements of an array to enable use of apecific aspects of the data 
               string[] parts = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
               //checks that all rows have all the required data and the origin and destination entered by the user are valid
               if (parts.Length == 7 && parts[1].Equals(origin) && parts[2].Equals(destination))
               {
                  int airlinePos = -1;
                  for (int i = 0; i < airlinesList.Count; i++)
                  {
                     AirlineClass ar = (AirlineClass)airlinesList[i];
                     if (ar.AirlineName.Equals(parts[0]))
                     {
                        //this variable will keep track of the position of each airline in the array
                        airlinePos = i;
                        break;
                     }
                  }

                  //if an airline doesent yet exist in an array an Airline Class object is created and all the fields are set
                  if (airlinePos == -1)
                  {
                     AirlineClass ar = new AirlineClass();
                     ar.AirlineName = parts[0];
                     ar.FlightCounter = 1;
                     ar.SumArrivalDelays = Convert.ToInt32(parts[4]);
                     ar.MaxArrivalDelay = Convert.ToInt32(parts[4]);
                     ar.SumDepartureDelays = Convert.ToInt32(parts[3]);
                     ar.MaxDepartureDelay = Convert.ToInt32(parts[3]);
                     airlinesList.Add(ar);
                  }

                  //if it's an exististing airline the necessary fields are updated accordingly
                  else
                  {
                     AirlineClass ar = (AirlineClass)airlinesList[airlinePos];
                     ar.FlightCounter++;
                     arrivalDelays = Convert.ToInt32(parts[4]);
                     departureDelays = Convert.ToInt32(parts[3]);
                     ar.SumArrivalDelays += arrivalDelays;
                     ar.SumDepartureDelays += departureDelays;
                     // checks the flight arrival delay to determine the maximum arrival delay for that airline
                     if (arrivalDelays > ar.MaxArrivalDelay)
                     {
                        ar.MaxArrivalDelay = arrivalDelays;

                     }
                     if (departureDelays > ar.MaxDepartureDelay)
                     {
                        ar.MaxDepartureDelay = departureDelays;
                     }

                  }
               }

            }
            // checks that there are such flights
            if (airlinesList.Count > 0)
            {
               //initializes the average departure and arrival delay to be able to determine which is the worst airport to fly from, and which is the worst airport to fly to
               AirlineClass air = (AirlineClass)airlinesList[0];
               int avgMaxArrivalDelay = air.SumArrivalDelays / air.FlightCounter;
               int avgMaxDepartureDelay = air.SumDepartureDelays / air.FlightCounter;
               String worstArrival = " ";
               String worstDeparture = " ";
               foreach (AirlineClass ar in airlinesList)
               {
                  // determines which is the worst airport to fly to by comparing average arrival delays 
                  if (ar.SumArrivalDelays / ar.FlightCounter > avgMaxArrivalDelay)
                  {
                     worstArrival = ar.AirlineName;
                     avgMaxArrivalDelay = ar.SumArrivalDelays / ar.FlightCounter;
                  }
                  // determines which is the worst airport to fly t0 by comparing average arrival delays
                  if (ar.SumDepartureDelays / ar.FlightCounter > avgMaxDepartureDelay)
                  {
                     worstDeparture = ar.AirlineName;
                     avgMaxDepartureDelay = ar.SumDepartureDelays / ar.FlightCounter;
                  }
                  // if there are no flights
                  if (ar.FlightCounter == 0)
                  {
                     Console.WriteLine("There are no flight from " + origin + " to " + destination + ".");
                  }
                  else
                  {
                     // if there are arrival delays
                     if (ar.SumArrivalDelays > 0)
                     {
                        Console.WriteLine("Airline: " + ar.AirlineName);
                        Console.WriteLine("There were " + ar.FlightCounter + " flights between these airports, and the average delay was " + (ar.SumArrivalDelays / ar.FlightCounter) + " minutes, the maximum delay being " + (ar.MaxArrivalDelay) + " minutes.");
                        // if the flights arrive ahead of time
                     }
                     else if (ar.SumArrivalDelays < 0)
                     {
                        Console.WriteLine("Airline: " + ar.AirlineName);
                        Console.WriteLine("There were " + ar.FlightCounter + " flights between these airports, and there were no delays, on average the flights came in " + (arrivalDelays) + " minutes ahead of time.");
                     }
                     //if there are no delays
                     else
                     {
                        Console.WriteLine("Airline: " + ar.AirlineName);
                        Console.WriteLine("There were " + ar.FlightCounter + " between these airports, and there are no delays on average. ");
                     }

                  }


               }
               //which is the worst airport from fly from based on the airport with the greatest  average departure delay 
               Console.WriteLine(worstDeparture + " is the worst airport to fly from.");
               //which is the worst airport to fly from based on the airport with the greatest average  arrival delay 
               Console.WriteLine(worstArrival + " is the worst airport to fly to.");

               Console.ReadLine();



            }
            else
            {
               Console.WriteLine("That was an invalid entry");
               Console.ReadLine();

            }
            myReader.Close();



         }
         catch (FileNotFoundException e)
         {

            Console.WriteLine(e.Message);
            Console.ReadLine();
            Environment.Exit(0);

         }
         catch (IOException ex)
         {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            Environment.Exit(0);
         }


      }

      static void Main(string[] args)
      {
         //get the orgin and destination from the user to calculate the average delay
         string origin;
         string destination;
         Console.WriteLine("Please enter the orgin airport");
         origin = Console.ReadLine();
         Console.WriteLine("Please enter the destination airport");
         destination = Console.ReadLine();
         printAverageDelay(origin, destination);

      }
   }
}
