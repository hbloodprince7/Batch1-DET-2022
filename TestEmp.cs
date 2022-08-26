using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmp
    {
        public static void Main()
        {
            Emp e = new Emp(1, "Tony Stark", "Los Angeles", 8055, 0509931, 75000, 2500);
            float NET = e.GetNetSalary();
            string GRADE = e.GetGrade();
            Console.WriteLine($"Net Salary = {NET}, Grade = {GRADE}");
        }
    }
}
