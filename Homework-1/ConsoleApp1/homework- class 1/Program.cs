#region RealCalculator
double num1 = 0;
double num2 = 0;

Console.Write("Enter the First number: ");
string input1 = Console.ReadLine();
if (!double.TryParse(input1, out num1))
{
    Console.WriteLine("Invalid input for the first number.");
    return;
}

Console.Write("Enter the Second number: ");
string input2 = Console.ReadLine();
if (!double.TryParse(input2, out num2))
{
    Console.WriteLine("Invalid input for the second number.");
    return;
}

Console.Write("Enter the Operation (+, -, *, /): ");
string operation = Console.ReadLine();

double result = 0;


switch (operation)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":


        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation.");
        return;
}


Console.WriteLine($"The result is: {result}");

#endregion

#region Average Number
double num1;
double num2;
double num3;
double num4;

Console.Write("Enter the First number: ");
string input1 = Console.ReadLine();
if (!double.TryParse(input1, out num1))
{
    Console.WriteLine("Invalid input for the first number.");
    return;
}


Console.Write("Enter the Second number: ");
string input2 = Console.ReadLine();
if (!double.TryParse(input2, out num2))
{
    Console.WriteLine("Invalid input for the second number.");
    return;
}


Console.Write("Enter the third number: ");
string input3 = Console.ReadLine();
if (!double.TryParse(input3, out num3))
{
    Console.WriteLine("Invalid input for the third number.");
    return;
}


Console.Write("Enter the fourth number: ");
string input4 = Console.ReadLine();
if (!double.TryParse(input4, out num4))
{
    Console.WriteLine("Invalid input for the fourth number.");
    return;
}


double average = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");
#endregion

#region Swap Numbers

int firstNumber;
int secondNumber;


Console.Write("Input the First Number: ");
bool isFirstValid = int.TryParse(Console.ReadLine(), out firstNumber);

if (!isFirstValid)
{
    Console.WriteLine("Invalid input for the first number.");
    return;
}


Console.Write("Input the Second Number: ");
bool isSecondValid = int.TryParse(Console.ReadLine(), out secondNumber);

if (!isSecondValid)
{
    Console.WriteLine("Invalid input for the second number.");
    return;
}


Console.WriteLine("Before Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);


int temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;


Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);

#endregion