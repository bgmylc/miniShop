using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models.Services
{
    public class FakeCategoryService : ICategoryService
    {
        public IList<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category{ID=1, Name="Elektronik Eşya"},
                new Category{ID=2, Name="Kitap" },
        };
        }
    }
}
