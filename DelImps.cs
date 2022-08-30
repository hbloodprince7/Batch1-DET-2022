using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class DelImps
    {
        public static void Main()
        {
            Action<string> act = (string name) => { Console.WriteLine($"Hello Mr. {name}"); };
            act.Invoke("Stark");

            Action<int, string> act1 = (int s, string sender) => { Console.WriteLine($"There are {s} new Messages from {sender}"); };
            act1.Invoke(4, "Ms. Potts");

            Action<int, string, string> act2 = (int a, string b, string c) => { Console.WriteLine($"There have been {a} sightings of {b} around {c} Area"); };
            act2.Invoke(7, "Bucky Barnes", "New York");
        }
    }
}
