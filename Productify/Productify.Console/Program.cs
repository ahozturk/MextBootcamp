using Productify.Domain;

ProductService productService = new();

// productService.Add("Iphone 12", "Apple's latest phone", 10000, 10);
// productService.Add("Samsung Galaxy S21", "Samsung's latest phone", 9000, 10);
// productService.Add("Xiaomi Mi 11", "Xiaomi's latest phone", 8000, 10);

productService.Delete(Guid.Parse("7632eaf5-2681-4a76-96e9-5991bfdf95f2"));

var products = productService.GetAll();

foreach (var product in products)
{
    Console.WriteLine(product.Name);
}