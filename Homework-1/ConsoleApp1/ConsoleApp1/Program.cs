#region exercise 5 
//int branchesPerTree = 12;
//int applesPerBranch = 8;
//int applesPerBasket = 5;

//Console.Write("Enter the number of trees: ");
//if (!int.TryParse(Console.ReadLine(), out int numberOfTrees) || numberOfTrees < 0)
//{
//    Console.WriteLine("Invalid input. Please enter a positive number.");
//    return;
//}

//int totalApples = numberOfTrees * branchesPerTree * applesPerBranch;


//int basketsNeeded = totalApples / applesPerBasket;

//Console.WriteLine("Total baskets required: " + basketsNeeded);
#endregion


#region exercise 6

//int num1 = 12;
//int num2 = 25;
//int max;

//if (num1 > num2)
//{
//    max = num1;
//}
//else
//{
//    max = num2;
//}

//Console.WriteLine($"The larger number is {max}");

//if (max % 2 == 0)
//{
//    Console.WriteLine("And it is even");
//}
//else
//{
//    Console.WriteLine("And it is odd");
//};
#endregion


#region exercise 7
Console.WriteLine("Enter a number between 1 and 3:");


string input = Console.ReadLine();


if (int.TryParse(input, out int number))
{
    switch (number)
    {
        case 1:
            Console.WriteLine("You got a new car!");
            break;
        case 2:
            Console.WriteLine("You got a new plane!");
            break;
        case 3:
            Console.WriteLine("You got a new bike!");
            break;
        default:
            Console.WriteLine("Invalid number! Please enter a number between 1 and 3.");
            break;
    }
}
else
{

    Console.WriteLine("Error: Please enter a valid number between 1 and 3.");
    };


#endregion 