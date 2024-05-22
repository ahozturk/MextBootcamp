using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> products = new();

        [HttpPost]
        public void Add(Product product) //Create
        {
            product.Id = Guid.NewGuid();
            products.Add(product);
            Console.WriteLine("Product added!");
        }

        [HttpGet]
        public List<Product> GetAll() //Read
        {
            return products;
        }

        [HttpDelete]
        public void Delete(Guid id) //Delete
        {
            foreach(var product in products) //"A", "B", "C"
            {
                if (product.Id == id)
                {
                    products.Remove(product);
                    break;
                }
            }
        }

        [HttpPut]
        public void Update(Guid id, Product updatedProduct) //Update
        {
            foreach(var product in products) //"A", "B", "C"
            {
                if (product.Id == id)
                {
                    product.Name = updatedProduct.Name;
                    break;
                }
            }
        }

    }
}
