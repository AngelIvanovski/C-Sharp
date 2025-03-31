using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enums;

namespace Classes
{
    public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName,
                        double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, Role.Other, workHours * payPerHour)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        private double WorkHours { get; set; }
        private int PayPerHour { get; set; }
        private Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}