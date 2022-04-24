namespace ExpenseTrackerApp.Models
{
    public interface IExpenseRepository
    {
        ExpenseModel GetExpense(int id);
        IEnumerable<ExpenseModel> GetAllExpense();
        ExpenseModel Add(ExpenseModel expense);
        ExpenseModel Update(ExpenseModel expense);
        ExpenseModel Delete(int id);
    }
}
