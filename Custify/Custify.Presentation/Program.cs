// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using Custify.Domain;

CustomerService customerService = new();

customerService.Add("Hakan");
customerService.Add("Merve");
customerService.Add("Gamze");
customerService.Add("Şeyda");

var customers = customerService.GetAll();

foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
    //Write Phone Number
}