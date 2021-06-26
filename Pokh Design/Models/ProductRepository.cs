using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokh_Design.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> AllProducts => _appDbContext.Products.Include(c=>c.Category);

        public IEnumerable<Product> ProductsOfTheWeek => _appDbContext.Products.Include(p=>p.Category).Where(p => p.IsProductOfTheWeek == true).ToList();

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p=>p.ProductId== productId);
        }
    }
}
