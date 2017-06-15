﻿using TechShop.Data.Infrastructure;
using TechShop.Model.Models;

namespace TechShop.Data.Repositories
{
    public interface IMenuGroupRepository: IRepository<MenuGroup>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}