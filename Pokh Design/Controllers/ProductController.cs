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
        public IActionResult List()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.AllProducts;

            productListViewModel.CurrentCategory = "Hand Made Furniture";
            return View(productListViewModel);
        }
    }
}
