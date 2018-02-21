using SportsStore.Data;
using SportsStore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext _dbcontext;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            _dbcontext = ctx;
        }

        public IQueryable<Product> Products => _dbcontext.Products;
    }

    
}
