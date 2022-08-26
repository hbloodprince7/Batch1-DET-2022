using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Emp
    {
        int Id;
        string Name;   
        string Address;
        int Pin;
        int Phone;
        float GSalary;
        float Pf;

        public Emp(int id, string name, string address, int pin, int phone, float gSalary, float pf)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Pin = pin;
            this.Phone = phone;
            this.GSalary = gSalary;
            this.Pf = pf;
        }

        public float GetNetSalary()
        {
            return (GSalary - Pf)*12;
        }

        public string GetGrade()
        {
            float net = GetNetSalary();
            if(net > 10000)
            {
                return "A";
            }
            else if (net > 5000 && net < 10000)
            {
                return "B";
            }
            else
            {
                return "C";
            }
        }
    }
}
