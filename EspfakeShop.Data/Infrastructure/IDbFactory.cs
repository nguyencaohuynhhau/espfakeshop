using System;

namespace EspfakeShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        EspfakeShopDbContext Init();
    }
}