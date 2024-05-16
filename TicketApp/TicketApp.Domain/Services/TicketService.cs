namespace TicketApp.Domain;

public class TicketService
{
    public void SaveTicketToTextFile(string ownerNameSurname, decimal price)
    {
        Random random = new();

        Ticket ticket = new()
        {
            Id = $"{random.Next(1, 1000)}",
            OwnerNameSurname = ownerNameSurname,
            Price = price
        };

        string ticketInfo = $"{ticket.Id},{ticket.OwnerNameSurname},{ticket.Price}\n";
        //1,Hakan Öztürk,100
        File.AppendAllText("/Users/hakan/Documents/GitHub/MextBootcamp/TicketApp/TicketApp.Domain/ticket.txt", ticketInfo);
    }
}
