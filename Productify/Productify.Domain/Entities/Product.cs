namespace Productify.Domain;

public class Product
{
    //Id, Name, Description, Price, Stock

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
