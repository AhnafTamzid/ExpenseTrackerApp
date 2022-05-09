using ExpenseTrackerApp.DataAccessLayer;

namespace ExpenseTrackerApp.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Expenses = new ExpenseRepository(_context);
            Categories = new CategoryRepository(_context);
        }

        public IExpenseRepository Expenses { get; set; }
        public ICategoryRepository Categories { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
