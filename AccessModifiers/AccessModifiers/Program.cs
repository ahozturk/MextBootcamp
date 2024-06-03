// See https://aka.ms/new-console-template for more information
using AccessModifiers;
using Domain;

Person person = new();
person.SetName("Do");
// person.Balance -= 1000;
person.Withdraw(150);

Product product = new();

Console.WriteLine("Hello, World!");
