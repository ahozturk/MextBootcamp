// See https://aka.ms/new-console-template for more information


string name = "Sena";

switch (name)
{
    case "Sena":
        Console.WriteLine("The name is Sena");
        break;

    case "Ali":
        Console.WriteLine("The name is Ali");
        break;

    case "Veli":
        Console.WriteLine("The name is Veli");
        break;

    default:
        Console.WriteLine("The name is not found");
        break; 
}

int number2 = 5;

string number2Text = number2 switch
{
    5 => "The number is 5",
    10 => "The number is 10",
    20 => "The number is 20",
    _ => "The number is not found"
};

Console.WriteLine($"Number 2 Text: {number2Text}");

int number = 10;

switch (number)
{
    case 5:
        Console.WriteLine("The number is 5");
        break;

    case 10:
        Console.WriteLine("The number is 10");
        break;

    case 20:
        Console.WriteLine("The number is 20");
        break;    
}