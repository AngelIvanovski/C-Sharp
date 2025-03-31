using Classes;
using Classes.Enums;

#region Exercise1

Employee employee1 = new Employee("Angel", "Ivanovski", Role.Other, 1000.00);

employee1.PrintInfo();

employee1.GetSalary();

#endregion

#region Exercise2

SalesPerson salesPerson1 = new SalesPerson("Sanchez", "Gonzalez", 2000.00);
salesPerson1.AddSuccessRevenue(6000.00);

Console.WriteLine("Salary after bonus:" + salesPerson1.GetSalary());

#endregion

#region Exercise3

Manager manager1 = new Manager("Filip", "Kiprijanovic", 2000.00);
manager1.AddBonus(10000.00);

Console.WriteLine("manager salary:");
Console.WriteLine(manager1.GetSalary());
#endregion

#region task 1

Manager manager2 = new Manager("Sanchezito", "Wang", 90000);
manager2.Department = "Engineering";

Contractor contractor = new Contractor("Tomy", "Lee", 160, 75, manager2);
Console.WriteLine("current position:");
Console.WriteLine(contractor.CurrentPosition());
#endregion
#region task 2



Manager manager4 = new Manager("Bob", "Bobert", 80000);
Manager manager5 = new Manager("Rick", "Rickert", 85000);

Contractor contractor1 = new Contractor("Mona", "Monalisa", 160, 50, manager1);
Contractor contractor2 = new Contractor("Igor", "Igorsky", 180, 60, manager2);

SalesPerson salesPerson2 = new SalesPerson("Lea", "Leova", 3000);


Employee[] Company = new Employee[]
{
            contractor1,
            contractor2,
            manager4,
            manager5,
            salesPerson2
};

Console.WriteLine("=========================================");
CEO ceo = new CEO("Ron", "Ronsky", 1500, 100, Company);
ceo.AddSharesPrice(14); 


Console.WriteLine("CEO:");
ceo.PrintInfo();
Console.WriteLine($"Salary of CEO: {ceo.GetSalary()}");


ceo.PrintEmployees();
#endregion