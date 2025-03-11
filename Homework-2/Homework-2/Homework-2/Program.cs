#region task 1

int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Enter integer no.{i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}


foreach (int num in numbers)
{
    if (num % 2 == 0)
    {
        sum += num;
    }
}

Console.WriteLine($"The result is: {sum}");
#endregion


#region task 2


string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Sandra", "Cvetan", "Aleks", "Darko", "David" };


Console.Write("Enter student group (1 or 2): ");
int groupChoice;


if (int.TryParse(Console.ReadLine(), out groupChoice) && (groupChoice == 1 || groupChoice == 2))
{

    if (groupChoice == 1)
    {
        Console.WriteLine("The Students in G1 are:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (groupChoice == 2)
    {
        Console.WriteLine("The Students in G2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
}
else
{

    Console.WriteLine("Invalid group number. Please enter 1 or 2.");
}
;

#endregion


#region task 3 

string[] names = new string[0]; 
string userChoice;

while (true)
{
    Console.Write("Enter a name: ");
    string name = Console.ReadLine();


    Array.Resize(ref names, names.Length + 1);


    names[names.Length - 1] = name;


    Console.Write("Do you want to enter another name? (Y/N): ");
    userChoice = Console.ReadLine().ToUpper();


    if (userChoice == "N")
        break;

 
    while (userChoice != "Y" && userChoice != "N")
    {
        Console.WriteLine("Invalid input! Please enter 'Y' for Yes or 'N' for No.");
        Console.Write("Do you want to enter another name? (Y/N): ");
        userChoice = Console.ReadLine().ToUpper();
    }
}


Console.WriteLine("Entered names:");
foreach (string name in names)
{
    Console.WriteLine(name);
}
#endregion