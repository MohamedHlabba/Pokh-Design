using Microsoft.AspNetCore.Mvc;
using Pokh_Design.Models;
using Pokh_Design.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokh_Design.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository )
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        //public IActionResult List()
        //{
        //    ProductListViewModel productListViewModel = new ProductListViewModel();
        //    productListViewModel.Products = _productRepository.AllProducts;

        //    productListViewModel.CurrentCategory = "Hand Made Furniture";
        //    return View(productListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p=>p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new ProductListViewModel { Products=products,CurrentCategory=currentCategory});

        }
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
