#region Main Program

// using CustomerApp;

// var customer = CreateCustomer();

// Console.WriteLine($"Customer: {customer.Name} {customer.Surname} {customer.PhoneNumber} {customer.Mail} {customer.Address} {customer.Gender}");



// Customer CreateCustomer()
// {
//     Console.WriteLine("Please enter the customer name:");
//     var name = Console.ReadLine();

//     Console.WriteLine("Please enter the customer surname:");
//     var surname = Console.ReadLine();

//     Console.WriteLine("Please enter the customer phone number:");
//     var phoneNumber = Console.ReadLine();

//     Console.WriteLine("Please enter the customer mail:");
//     var mail = Console.ReadLine();

//     Console.WriteLine("Please enter the customer address:");
//     var address = Console.ReadLine();

//     Console.WriteLine("Please enter the customer gender: (Female, Male, Unknown, NotPreferToSay, Other)");
//     var genderString = Console.ReadLine(); //"Male"

//     Gender gender = GetGenderFromString(genderString);

//     Customer customer = new Customer()
//     {
//         Name = name,
//         Surname = surname,
//         PhoneNumber = phoneNumber,
//         Mail = mail,
//         Address = address,
//         Gender = gender,
//     };

//     return customer;
// }

// Gender GetGenderFromString(string genderString)
// {
//     //male -> male
//     genderString = genderString.ToLower();

//     if (genderString == "female")
//         return Gender.Female;

//     else if (genderString == "male")
//         return Gender.Male;

//     else if (genderString == "unknown")
//         return Gender.Unknown;

//     else if (genderString == "notprefertosay")
//         return Gender.NotPreferToSay;

//     return Gender.Other;
// }
#endregion


using CustomerApp;

var newCustomer = new Customer("", "Öztürk");

Console.WriteLine($"Customer: {newCustomer.Name} - {newCustomer.Surname}");