// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using Custify.Domain;

CustomerService customerService = new();

customerService.Add("Hakan");

var customers = customerService.GetAll();

foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
}