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

// {
//   "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//   "name": "Hakan",
//   "surname": "Öztürk",
//   "email": "hakan@gmail.com",
//   "identificationNumber": "999111",
//   "phoneNumber": "0539",
//   "address": "İstanbul",
//   "gender": 2
// }