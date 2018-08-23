using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if(value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                }

                commissionRate = value;
            }
        }

        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return $"commission employee: {base.ToString()}\n" + $"gross sales: {GrossSales:C}\n" + $"commission rate: {CommissionRate:F2}";
        }
    }
}
