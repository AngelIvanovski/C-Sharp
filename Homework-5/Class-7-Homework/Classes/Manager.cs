using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enums;

namespace Classes
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary) : base(firstName, lastName, Role.Manager, salary)
        {
            Bonus = 0;
        }
        public string Department { get; set; } 
        private double Bonus { get; set; }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
