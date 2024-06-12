namespace Productify.Domain;

public interface IProductService
{
    void Add(string name, string description, decimal price, int stock);
    ICollection<Product> GetAll();
    void Delete(Guid id); 
    // void Update(Guid id, decimal price, int stock); 
}
