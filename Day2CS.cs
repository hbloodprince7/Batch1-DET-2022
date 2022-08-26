using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Day2CS
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }


        public static void Main()
        {
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(2, 3, 4));

            int[] a = {1, 2, 3, 4 };
            Console.WriteLine(Sum(a));
        }
    }
}
