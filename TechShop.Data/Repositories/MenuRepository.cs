﻿using TechShop.Data.Infrastructure;
using TechShop.Model.Models;

namespace TechShop.Data.Repositories
{
    public interface IMenuRepository
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}