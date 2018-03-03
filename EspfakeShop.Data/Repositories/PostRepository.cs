using EspfakeShop.Data.Infrastructure;
using EspfakeShop.Model.Models;

namespace EspfakeShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}