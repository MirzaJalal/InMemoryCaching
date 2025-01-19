using InMemoryCaching.Models;

namespace InMemoryCaching.Services
{
    public interface IProductService
    {
        Task<Product> Add(ProductCreationDto creationDto);
        Task<Product> Get(Guid id);
        Task<List<Product>> GetAll();
    }
}
