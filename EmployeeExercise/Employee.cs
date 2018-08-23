using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    public abstract class Employee
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string SocialSecurityNumber { get; }

        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            Firstname = firstName;
            Lastname = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} \n" + $"social security number: {SocialSecurityNumber}";
        }

        public abstract decimal Earnings();
    }
}
