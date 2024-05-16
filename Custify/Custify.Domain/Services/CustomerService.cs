namespace Custify.Domain;

public class CustomerService
{
    static List<Customer> _customers = new();

    public void Add(string name)
    {
        Random random = new();

        var newCustomer = new Customer()
        {
            Id = random.Next(1_000, 1_000_000),
            Name = name,
        };

        _customers.Add(newCustomer);
    }

    public List<Customer> GetAll()
    {
        return _customers;
    }
}
