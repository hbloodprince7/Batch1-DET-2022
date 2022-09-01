using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinQ
    {
        public static void Main()
        {
            SampleInList();




        }
        private static void SampleInList()
        {
            //1.DATA SOURCE
            List<string> avengers = new List<string>();
            avengers.Add("Iron Man");
            avengers.Add("Captain America");
            avengers.Add("Hawk Eye");
            avengers.Add("Hulk");


            //2.QUERY CREATION
            //DEFERRED EXECUTION:
            //var numQuery = from num in numbers where num>100 select num;
            var AvengersQuery = from hero in avengers select hero;
            //EARLY EXECUTION:
            //var numQuery = (from num in numbers select num).ToList();
            avengers.Add("Thor Odinson");
            avengers.Add("Black Widow");
 
            //3.QUERY EXECUTION
            foreach (string hero in AvengersQuery)
            {
                Console.WriteLine($"{hero}");
            }
        } 
    }
}
