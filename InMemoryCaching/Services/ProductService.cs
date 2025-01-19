using InMemoryCaching.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace InMemoryCaching.Services
{
    public class ProductService(AppDbContext context, IMemoryCache cache, ILogger<ProductService> logger) : IProductService
    {
        public async Task<Product> Add(ProductCreationDto creationDto)
        {
            var product = new Product(creationDto.Name, creationDto.Description, creationDto.Price);

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            // delete the cache if a new product is created

            var cacheKey = "productsList";
            logger.LogInformation("invalidating cache for key: {CacheKey} from cache.", cacheKey);
            cache.Remove(cacheKey);

            return product;
        }

        public async Task<Product> Get(Guid id)
        {
            var cacheKey = $"product:{id}";

            logger.LogInformation("query before setting cache to the key: {CacheKey} from cache.", cacheKey);
            if (!cache.TryGetValue(cacheKey, out Product? product))
            { 
                product = await context.Products.FindAsync(id);
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(3))
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30))
                    .SetPriority(CacheItemPriority.Normal);

                logger.LogInformation("setting data for key: {CacheKey} to cache.", cacheKey);
                cache.Set(cacheKey, product, cacheOptions);
            }
            else
            {

                logger.LogInformation("cache hit for key: {CacheKey}.", cacheKey);
            }
            return product;
        }

        public async Task<List<Product>> GetAll()
        {
            var cacheKey = $"productsList";
            logger.LogInformation("fetching data for key: {CacheKey} from cache.", cacheKey);
            if (!cache.TryGetValue(cacheKey, out List<Product>? products))
            {
                logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                products = await context.Products.ToListAsync();
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(30))
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(300))
                    .SetPriority(CacheItemPriority.NeverRemove)
                    .SetSize(2048);
                logger.LogInformation("setting data for key: {CacheKey} to cache.", cacheKey);
                cache.Set(cacheKey, products, cacheOptions);
            }
            else
            {
                logger.LogInformation("cache hit for key: {CacheKey}.", cacheKey);
            }
            return products;
        }
    }
}
