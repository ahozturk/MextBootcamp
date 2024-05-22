using Custify.Domain;
using Custify.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        CustomerService customerService = new();

        [HttpPost]
        public void Add(Customer customer)
        {
            customerService.Add(customer);
        }

        [HttpGet]
        public List<Customer> GetAll()
        {
            return customerService.GetAll();
        }

        [HttpPut]
        public void Update(Customer customer)
        {
            customerService.Update(customer);
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            customerService.Delete(id);
        }
    }
}
