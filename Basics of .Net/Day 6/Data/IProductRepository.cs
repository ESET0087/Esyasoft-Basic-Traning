using Day_6.Models;

namespace Day_6.Data
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}
