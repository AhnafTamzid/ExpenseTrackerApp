namespace ExpenseTrackerApp.Models
{
    public interface IUnitOfWork : IDisposable
    {
        IExpenseRepository Expenses { get; }
        ICategoryRepository Categories { get; }
        int Complete();
    }
}
