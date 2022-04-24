using ExpenseTrackerApp.DataAccessLayer;

namespace ExpenseTrackerApp.Models
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context = null;

        public ExpenseRepository(AppDbContext context)
        {
            _context = context;
        }
        public ExpenseModel Add(ExpenseModel model)
        {
            int id = model.CategoryId.HasValue ? model.CategoryId.Value : 0;

            var category = _context.CategoryModel.Find(id);
            model.Category = category.Name;
            _context.ExpenseModel.Add(model);
            _context.SaveChanges();

            return model;
        }

        public ExpenseModel Delete(int id)
        {
            ExpenseModel expenseModel = _context.ExpenseModel.Find(id);
            if (expenseModel != null)
            {
                _context.ExpenseModel.Remove(expenseModel);
                _context.SaveChanges();
            }

            return expenseModel;
        }

        public IEnumerable<ExpenseModel> GetAllExpense()
        {
            return _context.ExpenseModel;
        }

        public ExpenseModel GetExpense(int id)
        {
            return _context.ExpenseModel.Find(id);
        }
        public ExpenseModel Update(ExpenseModel model)
        {
            int id = model.CategoryId.HasValue ? model.CategoryId.Value : 0;
            var category = _context.CategoryModel.Find(id);
            model.Category = category.Name;

            var expense = _context.ExpenseModel.Attach(model);
            expense.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return model;
        }
    }
}