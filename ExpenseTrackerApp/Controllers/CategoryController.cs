using Microsoft.AspNetCore.Mvc;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ViewResult Index()
        {
            var model = _categoryRepository.GetAllCategory();
            return View(model);
        }

        public ViewResult Create(bool isSuccess = false, int id = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var categoryModel = _categoryRepository.Add(model);

                int id = model.Cid;
                if (id > 0 && categoryModel.Name != null)
                {
                    return RedirectToAction(nameof(Create), new { isSuccess = true, categoryId = id });
                }
            }
            ModelState.AddModelError("Name", "Category Already Exists!");
            return View(model);
        }

        public ViewResult Edit(int id,bool isSuccess = false, int cid = 0)
        {
            CategoryModel category = _categoryRepository.GetCategory(id);

            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = cid;
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var categoryModel = _categoryRepository.Update(model);

                int id = model.Cid;
                if (id > 0 && categoryModel.Name != null)
                {
                    return RedirectToAction(nameof(Index), new { isSuccess = true, categoryId = id });
                }
            }
            ModelState.AddModelError("Name", "Category Already Exists!");
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _categoryRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
