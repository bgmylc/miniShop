using System.Collections.Generic;

namespace miniShop.Models.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductsByCategoryID(int categoryID);
        void AddProduct(Product product);
    }
}