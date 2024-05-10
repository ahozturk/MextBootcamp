
List<string> people = new()
{
    "Müberra",
    "Şeyda",
};

Console.WriteLine("1 - List People");
Console.WriteLine("2 - Add Person");
Console.WriteLine("3 - Remove Person");
Console.WriteLine("4 - Update Person");

string selection = Console.ReadLine();

if (selection == "1")
{
    foreach (var person in people)
    {
        Console.WriteLine(person);
    }
}
else if (selection == "2")
{
    Console.WriteLine("Please enter a name: ");
    string name = Console.ReadLine();
    people.Add(name);
    Console.WriteLine($"{name} is saved!");
}
else if (selection == "3")
{
    Console.WriteLine("Please enter a name to delete: ");
    string name = Console.ReadLine();
    people.Remove(name);
    Console.WriteLine($"{name} is deleted!");
}
else if (selection == "4")
{
    Console.WriteLine("Please enter a name to update: ");
    string name = Console.ReadLine();

    int index = people.IndexOf(name);

    Console.WriteLine("Please enter updated version: ");
    string nameUpdated = Console.ReadLine();

    people[index] = nameUpdated;

    Console.WriteLine($"{name} is updated to {nameUpdated}!");
    Console.WriteLine();
}