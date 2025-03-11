Console.Write("Please enter your birthdate (YYYY-MM-DD): ");
string inputDate = Console.ReadLine();

int age = AgeCalculator(inputDate);

Console.WriteLine($"Your age is: {age}");

int AgeCalculator(string birthday)
{

    DateTime birthDate = DateTime.Parse(birthday);

    DateTime today = DateTime.Today;

    int age = today.Year - birthDate.Year;

    if (birthDate.Date > today.AddYears(-age))
    {
        age--;
    }

    return age;
};