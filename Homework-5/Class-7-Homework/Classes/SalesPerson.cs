using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enums;

namespace Classes
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName,double successSaleRevenue) : base(firstName, lastName, Role.Sales, 500)
        {   
            SuccessSaleRevenue = successSaleRevenue;
        }
        private double SuccessSaleRevenue { get; set; }


        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue = revenue;
        }
        public override double GetSalary()
        {
            double bonus;
            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else
            {
                bonus = 1500;
            }

            return Salary + bonus;

        }
    }
}

