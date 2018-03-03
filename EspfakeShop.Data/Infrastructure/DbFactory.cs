namespace EspfakeShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private EspfakeShopDbContext dbContext;

        public EspfakeShopDbContext Init()
        {
            return dbContext ?? (dbContext = new EspfakeShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}