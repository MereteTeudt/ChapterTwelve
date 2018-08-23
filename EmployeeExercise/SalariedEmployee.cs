using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, decimal weeklySalary)
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(WeeklySalary)} must be >= 0");
                }
                weeklySalary = value;
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary;   
        }

        public override string ToString()
        {
            return $"salaried employee: {base.ToString()}\n" +
                $"weekly salary: {WeeklySalary:C}";
        }
    }
}
