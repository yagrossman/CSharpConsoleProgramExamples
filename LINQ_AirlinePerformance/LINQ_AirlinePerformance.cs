using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AirlinePerformance
{
   class LINQ_AirlinePerformance
   {
      static void Main(string[] args)
      {
         var flights = FlightInfo.ReadFlightsFromFile("airline-on-time-performance-sep2014-us.csv");

         var arrivalDelayBostonToChicago = from flight in flights
                                            where flight.Origin == "Boston MA"
                                            && flight.Destination == "Chicago IL"
                                            select flight.ArrivalDelay;

         var airportsDirectToMonterey = (from flight in flights
                                  where flight.Destination == "Monterey CA"
                                  select flight.Origin).Distinct();

         var originDestOf10LargestArrivalDelay = (from flight in flights
                                                   orderby flight.ArrivalDelay descending
                                                   select new { flight.Origin, flight.Destination, flight.ArrivalDelay }).Take(10);

         var destOfFirst20Flights = from flight in flights.Take(20)
                                    select flight.Destination;

         var avgArrivalDelay = (from flight in flights
                               select flight.ArrivalDelay).Average();
         //Console.WriteLine(avgArrivalDelay);

         var shortestFlight = (from flight in flights
                               orderby flight.Distance ascending
                               select new {flight.Origin, flight.Destination, flight.Distance}).Take(1);

         var longestFlightFromSanFran = (from flight in flights
                                    where flight.Origin == "San Francisco CA"
                                    orderby flight.Distance descending
                                    select new {flight.Destination, flight.Distance }).Take(1);

         var largestWeightedArrivalDelayFromBoston = (from flight in flights
                                                     where flight.Origin == "Boston MA"
                                                     let weightedDelay = flight.ArrivalDelay / (double)flight.Distance
                                                     orderby weightedDelay descending
                                                     select new { flight.Destination, flight.ArrivalDelay }).Take(1);

         var fromSeattleNoArrivalDelay = (from flight in flights
                                         where flight.Origin == "Seattle WA"
                                         && flight.ArrivalDelay <= 0
                                         select flight).Count();
         //Console.WriteLine(fromSeattleNoArrivalDelay);

         var top10OriginLargestAvgDepartureDelays = (from flight in flights
                                                     group flight.DepartureDelay by flight.Origin into g
                                                     let avgDelay = g.Average()
                                                     orderby avgDelay descending
                                                     select new { Airport = g.Key, DepartureDelay = avgDelay }).Take(10);

         foreach (var flight in top10OriginLargestAvgDepartureDelays)
         {
            Console.WriteLine(flight);
         }

         Console.ReadLine();
      }
   }
}
