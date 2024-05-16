namespace Custify.Domain;

public class CustomerService
{
    static List<Customer> _customers = new();

    public void Add(string name)
    {
        Random random = new();

        new Customer()
        {
            Id = random.Next(1_000, 1_000_000),
        }
    }
}
