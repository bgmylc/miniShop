using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using miniShop.Models;
using miniShop.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }


        public IActionResult Create()
        {
            List<SelectListItem> selectListItems = GetCategorysToSelect();

            ViewBag.Items = selectListItems;
            return View();


        }

        private List<SelectListItem> GetCategorysToSelect()
        {
            var categories = categoryService.GetCategories();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            categories.ToList().ForEach(c => selectListItems.Add(new SelectListItem
            {
                Text = c.Name,
                Value = c.ID.ToString()

            }));
            return selectListItems;
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {

            if (ModelState.IsValid)
            {
                productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            
            List<SelectListItem> selectListItems = GetCategorysToSelect();
            ViewBag.Items = selectListItems;

            return View();
        
        }






    }
}
