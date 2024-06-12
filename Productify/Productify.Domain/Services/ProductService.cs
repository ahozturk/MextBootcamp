
namespace Productify.Domain;

public class ProductService : IProductService
{
    public void Add(string name, string description, decimal price, int stock)
    {
        Guid id = Guid.NewGuid();

        string csvFormat = $"{id},{name},{description},{price},{stock}\n";

        string filePath = "/Users/hakan/Documents/GitHub/MextBootcamp/Productify/Productify.Domain/products.txt";

        File.AppendAllText(filePath, csvFormat);
    }

    public void Delete(string id)
    {
        string fullText = File.ReadAllText("/Users/hakan/Documents/GitHub/MextBootcamp/Productify/Productify.Domain/products.txt");
    
        string[] lines = fullText.Split("\n");

        string newData = "";

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            string[] columns = line.Split(",");

            if (columns[0] == id)
            {
                continue;
            }

            newData += line + "\n";
        }

        File.WriteAllText("/Users/hakan/Documents/GitHub/MextBootcamp/Productify/Productify.Domain/products.txt", newData);
    }

    public ICollection<Product> GetAll()
    {
        string fullText = File.ReadAllText("/Users/hakan/Documents/GitHub/MextBootcamp/Productify/Productify.Domain/products.txt");
    
        string[] lines = fullText.Split("\n");

        List<Product> products = new();

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            string[] columns = line.Split(",");

            Product product = new()
            {
                Id = Guid.Parse(columns[0]),
                Name = columns[1],
                Description = columns[2],
                Price = decimal.Parse(columns[3]),
                Stock = int.Parse(columns[4])
            };

            products.Add(product);
        }

        return products;
    }
}
