using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TechShopDbContext dbContext;

        public TechShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TechShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
