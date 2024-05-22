using Custify.Domain.Entities;

namespace Custify.Domain;

public class CustomerService
{
    private static List<Customer> customers = new();

    public List<Customer> GetAll()
    {
        return customers;
    }

    public void Add(Customer customer) // Will return result
    {
        customer.Id = Guid.NewGuid();
        customers.Add(customer);
    }

    public void Update(Customer updateCustomer)
    {
        foreach (var customer in customers)
        {
            if (customer.Id == updateCustomer.Id)
            {
                customer.Name = updateCustomer.Name;
                customer.Surname = updateCustomer.Surname;
                customer.Email = updateCustomer.Email;
                customer.PhoneNumber = updateCustomer.PhoneNumber;
                customer.Address = updateCustomer.Address;
                break;
            }
        }
    }

    public void Delete(Guid id)
    {
        foreach (var customer in customers)
        {
            if (customer.Id == id)
            {
                customers.Remove(customer);
                break;
            }
        }
    }
}
