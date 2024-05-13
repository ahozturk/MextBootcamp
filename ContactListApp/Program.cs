﻿#region no-model
using ContactListApp;

List<Person> people = new()
{
    new Person()
    {
        Name = "Müberra",
        Surname = "Kaya",
        PhoneNumber = "1234567890"
    },
    new Person()
    {
        Name = "Şeyda",
        Surname = "Kaya",
        PhoneNumber = "0987654321"
    }
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
        Console.WriteLine($"{person.Name}-{person.Surname}-{person.PhoneNumber}"); //Name-Surname-PhoneNumber
}

void AddPerson()
{
    string name = ReadConsoleWithMessage("Please enter a name: ");
    string surname = ReadConsoleWithMessage("Please enter a surname: ");
    string phoneNumber = ReadConsoleWithMessage("Please enter a phone number: ");

    Person person = new()
    {
        Name = name,
        Surname = surname,
        PhoneNumber = phoneNumber
    };

    people.Add(person);
    Console.WriteLine($"{name} is saved!");    
}

void DeletePerson()
{
    string phoneNumber = ReadConsoleWithMessage("Please enter a phone number to delete: ");
    string name = "";
    foreach(var person in people)
    {
        if(person.PhoneNumber == phoneNumber)
        {
            name = person.Name;
            people.Remove(person);
            return;
        }
    }

    Console.WriteLine($"{name} is deleted!");
}

void UpdatePerson()
{
    // string name = ReadConsoleWithMessage("Please enter a name to update: ");

    // int index = people.IndexOf(name);

    // string nameUpdated = ReadConsoleWithMessage("Please enter updated version: ");

    // people[index] = nameUpdated;

    // Console.WriteLine($"{name} is updated to {nameUpdated}!");
    // Console.WriteLine();
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

PersonService personService = new();
personService.AddPerson();

class PersonService
{   
    /// <summary>
    /// Kişi eklemek için yazılmış olan metot.
    /// </summary>
    public void AddPerson()
    {

    }

}
#endregion

// using ContactListApp;

//değişken tipi  değişken ismi = değer

// List<Person> people = new()
// {
//     new Person()
//     {
//         Name = "Müberra",
//         Surname = "Kaya",
//         PhoneNumber = "1234567890"
//     },
//     new Person()
//     {
//         Name = "Şeyda",
//         Surname = "Kaya",
//         PhoneNumber = "0987654321"
//     }
// };

// Person person3 = new()
// {
//     Name = "Hilal",
//     Surname = "Durdaç",
//     PhoneNumber = "8714567890"
// };
// Console.WriteLine($"Name: {person3.Name}");

// people.Add(person3);
