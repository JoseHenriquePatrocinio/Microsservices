using CatalogAPI.Entities;

namespace CatalogAPI.Repositories
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(String id);
        Task<IEnumerable<Product>> GetProductByName(String name);
        Task<IEnumerable<Product>> GetProductByCategory(String category);

        Task CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(String id);

    }
}
