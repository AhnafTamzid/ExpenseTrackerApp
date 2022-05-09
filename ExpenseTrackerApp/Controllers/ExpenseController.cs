using ExpenseTrackerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseController : Controller
    {
        //private readonly IExpenseRepository _expenseRepository;
        //private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ExpenseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_expenseRepository = expenseRepository;
            //_categoryRepository = categoryRepository;
        }
        public ViewResult Index()
        {
            var model = _unitOfWork.Expenses.GetAllExpense();
            //var model = _expenseRepository.GetAllExpense();
        
            return View(model);
        }

        public ViewResult Create(bool isSuccess = false, int id=0)
        {
            ViewBag.Category = new SelectList(_unitOfWork.Categories.GetAllCategory(),"Cid","Name");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExpenseModel model)
        {
            if (ModelState.IsValid)
                {
                _unitOfWork.Expenses.Add(model);

                int id = model.Eid;
                if (id > 0)
                {
                    return RedirectToAction(nameof(Create), new { isSuccess = true, expenseId = id });
                }
            }

            ViewBag.Category = new SelectList(_unitOfWork.Categories.GetAllCategory(),"Cid","Name");
            
            return View(model);
        }

        public ViewResult Edit(int id,bool isSuccess = false, int vid = 0)
        {
            ExpenseModel expense = _unitOfWork.Expenses.GetExpense(id);

            ViewBag.Category = new SelectList(_unitOfWork.Categories.GetAllCategory(), "Cid", "Name");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Id = vid;
            return View(expense);
        }

        [HttpPost]
        public IActionResult Edit(ExpenseModel model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Expenses.Update(model);

                int id = model.Eid;
                if (id > 0)
                {
                    return RedirectToAction(nameof(Index), new { isSuccess = true, expenseId = id });
                }
            }
            ViewBag.Category = new SelectList(_unitOfWork.Categories.GetAllCategory(), "Cid", "Name");
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _unitOfWork.Expenses.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
