using EspfakeShop.Data.Infrastructure;
using EspfakeShop.Model.Models;

namespace EspfakeShop.Data.Repositories
{ 
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}