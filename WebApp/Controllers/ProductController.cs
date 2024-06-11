using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities.Concretes;
using DataAccess.Repositories.Abstracts;

namespace WebApp.Controllers {
    public class ProductController : Controller {
        // Fields

        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        // Constructor

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository) { 
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // Methods

        // Create

        public async Task<IActionResult> AddProduct() {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories != null) return View(new ProductVM { Categories = categories });
            else return View(new ProductVM { Categories = new List<Category>() });
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductVM viewModel) {
            await _productRepository.AddAsync(new Product() {
                Name = viewModel.Name,
                ImageUrl = viewModel.ImageUrl,
                CategoryId = viewModel.CategoryId,
                Description = viewModel.Description,
            });

            return View(viewModel);
        }

        // Read

        public async Task<IActionResult> GetAllProducts() {
            return View(await _productRepository.GetAllAsync());
        }

        // Update

        public async Task<IActionResult> UpdateProduct() {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories != null) return View(new ProductVM { Categories = categories });
            else return View(new ProductVM { Categories = new List<Category>() });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductVM viewModel) {
            var product = await _productRepository.GetByIdAsync(viewModel.Id);
            product.Name = viewModel.Name;
            product.ImageUrl = viewModel.ImageUrl;
            product.CategoryId = viewModel.CategoryId;
            product.Description = viewModel.Description;
            await _productRepository.Update(product);
            return View(viewModel);
        }

        // Delete

        public async Task<IActionResult> DeleteProduct() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductVM viewModel) {

            await _productRepository.DeleteAsync(viewModel.Id);
            return View(viewModel); 
        }
    }
}
