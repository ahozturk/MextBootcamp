
List<string> people = new();



//Add Person
people.Add("Alice"); //0
people.Add("Hakan"); //1
people.Add("Bob"); //2

//List People
foreach (string person in people)
{
    Console.WriteLine(person);
}
Console.WriteLine("**********");
//Remove Person
people.Remove("Bob");

//List People
foreach (string person in people)
{
    Console.WriteLine(person);
}
Console.WriteLine("**********");

//Update Person
people[0] = "Alice Smith";
people[1] = "Hakan Öztürk";

//List People
foreach (string person in people)
{
    Console.WriteLine(person);
}
