// See https://aka.ms/new-console-template for more information
using CustomerApp;

Console.WriteLine("Hello, World!");

var customer = CreateCustomer();

Console.WriteLine($"Customer: {customer.Name} {customer.Surname} {customer.PhoneNumber} {customer.Mail} {customer.Address} {customer.Gender}");

Customer CreateCustomer()
{
    Console.WriteLine("Please enter the customer name:");
    var name = Console.ReadLine();

    Console.WriteLine("Please enter the customer surname:");
    var surname = Console.ReadLine();

    Console.WriteLine("Please enter the customer phone number:");
    var phoneNumber = Console.ReadLine();

    Console.WriteLine("Please enter the customer mail:");
    var mail = Console.ReadLine();

    Console.WriteLine("Please enter the customer address:");
    var address = Console.ReadLine();

    Console.WriteLine("Please enter the customer gender: (Female, Male, Unknown, NotPreferToSay, Other)");
    var genderString = Console.ReadLine(); //"Female"

    Gender gender = GetGenderFromString(genderString);

    Customer customer = new()
    {
        Name = name,
        Surname = surname,
        PhoneNumber = phoneNumber,
        Mail = mail,
        Address = address,
        Gender = gender,
    };

    return customer;
}

Gender GetGenderFromString(string genderString)
{
    genderString = genderString.ToLower();

    if (genderString == "female")
        return Gender.Female;

    else if (genderString == "male")
        return Gender.Male;

    else if (genderString == "unknown")
        return Gender.Unknown;

    else if (genderString == "notprefertosay")
        return Gender.NotPreferToSay;

    return Gender.Other;
}