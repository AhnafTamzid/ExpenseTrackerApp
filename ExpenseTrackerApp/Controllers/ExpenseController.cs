using ExpenseTrackerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ExpenseController(IExpenseRepository expenseRepository, ICategoryRepository categoryRepository)
        {
            _expenseRepository = expenseRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult Index()
        {
            var model = _expenseRepository.GetAllExpense();
        
            return View(model);
        }

        public ViewResult Create(bool isSuccess = false, int id=0)
        {
            ViewBag.Category = new SelectList(_categoryRepository.GetAllCategory(),"Cid","Name");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExpenseModel model)
        {
            if (ModelState.IsValid)
                {
                _expenseRepository.Add(model);

                int id = model.Eid;
                if (id > 0)
                {
                    return RedirectToAction(nameof(Create), new { isSuccess = true, expenseId = id });
                }
            }

            ViewBag.Category = new SelectList(_categoryRepository.GetAllCategory(),"Cid","Name");
            
            return View(model);
        }

        public ViewResult Edit(int id,bool isSuccess = false, int vid = 0)
        {
            ExpenseModel expense = _expenseRepository.GetExpense(id);

            ViewBag.Category = new SelectList(_categoryRepository.GetAllCategory(), "Cid", "Name");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = vid;
            return View(expense);
        }

        [HttpPost]
        public IActionResult Edit(ExpenseModel model)
        {
            if (ModelState.IsValid)
            {
                _expenseRepository.Update(model);

                int id = model.Eid;
                if (id > 0)
                {
                    return RedirectToAction(nameof(Index), new { isSuccess = true, expenseId = id });
                }
            }
            ViewBag.Category = new SelectList(_categoryRepository.GetAllCategory(), "Cid", "Name");
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _expenseRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
