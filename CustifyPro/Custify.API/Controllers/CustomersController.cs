using Custify.Domain;
using Custify.Domain.Entities;
using Custify.Domain.Enums;
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
        public List<GetCustomerDto> GetAll()
        {
            return customerService.GetAll();
        }

        [HttpPut]
        public void Update(UpdateCustomerDto updateCustomerDto)
        {
            customerService.Update(updateCustomerDto);
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            customerService.Delete(id);
        }
    }
}
