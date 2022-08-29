using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Person
    {
        string FirstName;
        string LastName;
        string Email;
        DateOnly DOB;
        
        public Person(string firstName, string lastName, string email, DateOnly dOB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = dOB;
        }
        public Person(string firstName,string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
        public Person(string firstName, string lastName, DateOnly dOB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dOB;
        }
        private static int CalculateAge(DateOnly DOB)
        {
            int age = 0;
            age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
                age = age - 1;

            return age;
        }

        public string GetWeddingAgeStatus(int age)
        {   
            if(age > 21)
            {
                return "ELIGIBLE TO MARRY";
            }
            else
            {
                return "INELIGIBLE TO MARRY";
            }
        }
        public string GetSunSign()
        {
            string str = string.Empty;
            int month = DOB.Month;
            int day = DOB.Day;
            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
            {
                return "Aires";
            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
            {
                return "Taurus";
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
            {
                return "Gemini";
            }
            if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
            {
                return "Cancer";
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
            {
                return "leo";
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))
            {
                return "Virgo";
            }
            else
            {
                return "SUN SIGN UNKOWN";
            }
        }
        public string BDayStatus()
        {
            var dateNow = DateOnly.FromDateTime(DateTime.Now);
            if(DOB == dateNow)
            {
                return "IT IS THE PERSONS BIRTHDAY";
            }
            else
            {
                return "IT IS NOT THE BIRTHDAY";
            }
        }
    }
}
