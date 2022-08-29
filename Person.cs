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
    }
}
