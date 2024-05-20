using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        static List<string> orderList = new();

        [HttpPost]
        public void Add(string order)
        {
            orderList.Add(order);
            Console.WriteLine($"{order} order added successfully.");
        }

        [HttpGet]
        public List<string> Get()
        {
            return orderList;
        }

        [HttpDelete]
        public void Delete(string order)
        {
            orderList.Remove(order);
            Console.WriteLine($"{order} order deleted successfully.");
        }

        [HttpPut]
        public void Update(string oldOrder, string newOrder) //Orta Boy Filtre, Orta Boy Filtre Kahve
        {
            int index = orderList.IndexOf(oldOrder);
            orderList[index] = newOrder;
            Console.WriteLine($"{oldOrder} order updated to {newOrder} successfully.");
        }
    }
}
