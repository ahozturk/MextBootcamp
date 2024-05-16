namespace TicketApp.Domain;

public class TicketService
{
    public void SaveTicketToTextFile(string ownerNameSurname, decimal price)
    {
        Ticket ticket = new()
        {
            OwnerNameSurname = ownerNameSurname,
            Price = price
        };

        string ticketInfo = $"{ticket.Id},{ticket.OwnerNameSurname},{ticket.Price}";
        //1,Hakan Öztürk,100
        File.AppendAllText("/Users/hakan/Documents/GitHub/MextBootcamp/TicketApp/TicketApp.Domain/ticket.txt", ticketInfo);
    }
}
