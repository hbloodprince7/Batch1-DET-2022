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
            Emp ceo = new Emp(1, "Tony Stark", "Los Angeles", 8055, 0509931, 75000, 7500);
            float NET = ceo.GetNetSalary();
            string GRADE = ceo.GetGrade();
            Console.WriteLine($"Net Salary = {NET}, Grade = {GRADE}");
        }
    }
}
