using ContactDbApp.Domain;

ContactDbAppDbContext context = new();

// Product product1 = new()
// {
//     Id = Guid.NewGuid(),
//     Title = "Product 2",
//     Price = 450,
// };

// context.Products.Add(product1);

// context.SaveChanges();

var products = context.Products.ToList();

foreach (var product in products)
{
    Console.WriteLine($"{product.Title} - {product.Price}");
}