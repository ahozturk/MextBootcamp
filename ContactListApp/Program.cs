﻿
List<string> people = new()
{
    "Müberra",
    "Şeyda",
};

void PrintMenu()
{
    Console.WriteLine("1 - List People");
    Console.WriteLine("2 - Add Person");
    Console.WriteLine("3 - Remove Person");
    Console.WriteLine("4 - Update Person");
}

string ReadConsoleWithMessage(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

while (true)
{
    PrintMenu();

    // Console.WriteLine("Enter a selection:");
    // string selection = Console.ReadLine();

    string selection = ReadConsoleWithMessage("Enter a selection:");

    if (selection == "1")
    {
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
    else if (selection == "2")
    {
        // Console.WriteLine("Please enter a name: ");
        // string name = Console.ReadLine();

        string name = ReadConsoleWithMessage("Please enter a name: ");

        people.Add(name);
        Console.WriteLine($"{name} is saved!");
    }
    else if (selection == "3")
    {
        // Console.WriteLine("Please enter a name to delete: ");
        // string name = Console.ReadLine();

        string name = ReadConsoleWithMessage("Please enter a name to delete: ");

        people.Remove(name);
        Console.WriteLine($"{name} is deleted!");
    }
    else if (selection == "4")
    {
        // Console.WriteLine("Please enter a name to update: ");
        // string name = Console.ReadLine();

        string name = ReadConsoleWithMessage("Please enter a name to update: ");

        int index = people.IndexOf(name);

        // Console.WriteLine("Please enter updated version: ");
        // string nameUpdated = Console.ReadLine();

        string nameUpdated = ReadConsoleWithMessage("Please enter updated version: ");

        people[index] = nameUpdated;

        Console.WriteLine($"{name} is updated to {nameUpdated}!");
        Console.WriteLine();
    }
}