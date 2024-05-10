
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

void PrintPeople()
{
    foreach (var person in people)
        Console.WriteLine(person);
}

void AddPerson()
{
    string name = ReadConsoleWithMessage("Please enter a name: ");
    people.Add(name);
    Console.WriteLine($"{name} is saved!");    
}

void DeletePerson()
{
    string name = ReadConsoleWithMessage("Please enter a name to delete: ");

    people.Remove(name);
    Console.WriteLine($"{name} is deleted!");
}

void UpdatePerson()
{
    string name = ReadConsoleWithMessage("Please enter a name to update: ");

    int index = people.IndexOf(name);

    string nameUpdated = ReadConsoleWithMessage("Please enter updated version: ");

    people[index] = nameUpdated;

    Console.WriteLine($"{name} is updated to {nameUpdated}!");
    Console.WriteLine();
}

while (true)
{
    PrintMenu();

    string selection = ReadConsoleWithMessage("Enter a selection:");

    if (selection == "1")
        PrintPeople();

    else if (selection == "2")
        AddPerson();
        
    else if (selection == "3")
        DeletePerson();        

    else if (selection == "4")
        UpdatePerson();
}
