using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities.Concretes;
using DataAccess.Repositories.Abstracts;

namespace WebApp.Controllers {
    public class CategoryController : Controller {

        // Fields

        private readonly ICategoryRepository _categoryRepository;

        // Constructor

        public CategoryController(ICategoryRepository categoryRepository) { 
            _categoryRepository = categoryRepository;
        }

        // Methods

        // Create

        public async Task<IActionResult> AddCategory() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryVM viewModel) {
            await _categoryRepository.AddAsync(new Category() {
                Name = viewModel.CategoryName
            });

            return View(viewModel);
        }

        // Read

        public async Task<IActionResult> GetAllCategories() {
            return View(await _categoryRepository.GetAllAsync());
        }

        // Update

        public async Task<IActionResult> UpdateCategory() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(CategoryVM viewModel) {
            var category = await _categoryRepository.GetByIdAsync(viewModel.Id);
            category.Name = viewModel.CategoryName;
            await _categoryRepository.Update(category);
            return View(viewModel);
        }

        // Delete

        public async Task<IActionResult> DeleteCategory() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(CategoryVM viewModel) {

            await _categoryRepository.DeleteAsync(viewModel.Id);
            return View(viewModel); 
        }
    }
}
