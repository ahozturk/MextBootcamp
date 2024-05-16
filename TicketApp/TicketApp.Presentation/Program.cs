// See https://aka.ms/new-console-template for more information
using TicketApp.Domain;

TicketService ticketService = new();

//1:
// Ticket ticket = new()
// {
//     OwnerNameSurname = "Hakan Öztürk",
//     Price = 100
// };

// ticketService.SaveTicketToTextFile(ticket);

ticketService.SaveTicketToTextFile("Hakan Öztürk", 100);

Console.WriteLine("Ticket saved to text file.");