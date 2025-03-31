using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enums;

namespace Classes
{
    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees)
            : base(firstName, lastName, Role.Other, salary)
        {
            Shares = shares;
            Employees = employees;
        }

        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}
