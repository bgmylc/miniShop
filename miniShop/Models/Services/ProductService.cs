using Microsoft.EntityFrameworkCore;
using miniShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models.Services
{
    public class ProductService : IProductService
    {
        private miniShopDbContext dbContext;

        public ProductService(miniShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            var products = dbContext.Products.AsNoTracking().ToList();
            return products;
        }

        public List<Product> GetProductsByCategoryID(int categoryID)
        {
            return dbContext.Products.AsNoTracking().Where(p => p.CategoryID == categoryID).ToList();
        }
    }
}
