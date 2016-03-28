using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary
{
   class ListDictionary
   {
      static void Main(string[] args)
      {
         List<string> myFriends = new List<string> { "BOB", "JOE", "HARRY", "MITCH" };
         Dictionary<string, int> friendsAges = new Dictionary<string, int>
         {
            {"BOB", 22 },
            {"JOE", 25 },
            {"HARRY", 32 },
         };
         isFriend(myFriends);
         oldestYoungest(friendsAges);
         Console.ReadLine();
      }

      public static void isFriend(List<string> friendList)
      {
         Console.WriteLine("Type in a friends name to check if s/he is in the list: ");
         string name = Console.ReadLine().ToUpper();
         if (friendList.Contains(name))
         {
            Console.WriteLine("{0} is in the list.", name);
         }
         else
         {
            Console.WriteLine("{0} is NOT in the list.", name);
         }
      }
      public static void oldestYoungest(Dictionary<string, int> friendList)
      {
         Console.WriteLine("{0} is the oldest friend,\n{1} is the youngest friend.",
            friendList.FirstOrDefault(x => x.Value == friendList.Values.Max()).Key,
            friendList.FirstOrDefault(x => x.Value == friendList.Values.Min()).Key
            );
      }
   }
}
