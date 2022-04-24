namespace ExpenseTrackerApp.Models
{
    public interface ICategoryRepository
    {
        CategoryModel GetCategory(int id);
        IEnumerable<CategoryModel> GetAllCategory();
        CategoryModel Add(CategoryModel category);
        CategoryModel Update(CategoryModel category);
        CategoryModel Delete(int id);
    }
}