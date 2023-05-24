Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");

var input = Console.ReadLine();
int num1 = int.Parse(input);

Console.WriteLine("Input the second number: ");

input = Console.ReadLine();
int num2 = int.Parse(input);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]ultiply numbers");

var userChoice = Console.ReadLine();

switch(userChoice)
{
    case ("A"):
    case ("a"):
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case ("S"):
    case ("s"):
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case ("M"):
    case ("m"):
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

