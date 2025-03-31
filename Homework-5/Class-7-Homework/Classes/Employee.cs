using Classes.Enums;

namespace Classes
{
    public class Employee
    {

        public Employee(string firstName, string lastName, Role role,double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
