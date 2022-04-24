using ExpenseTrackerApp.DataAccessLayer;

namespace ExpenseTrackerApp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context = null;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public CategoryModel Add(CategoryModel model)
        {
            var searchCategory = _context.CategoryModel.Where(c => c.Name == model.Name).ToList();
            if (searchCategory.Count == 0)
            {
                _context.CategoryModel.Add(model);
                _context.SaveChanges();

                return model;
            }
            model.Name = "";
            return model;
        }

        public CategoryModel Delete(int id)
        {
            CategoryModel categoryModel = _context.CategoryModel.Find(id);
            if (categoryModel != null)
            {
                _context.CategoryModel.Remove(categoryModel);
                _context.SaveChanges();
            }

            return categoryModel;
        }

        public IEnumerable<CategoryModel> GetAllCategory()
        {
            return _context.CategoryModel;
        }

        public CategoryModel GetCategory(int id)
        {
            return _context.CategoryModel.Find(id);
        }

        public CategoryModel Update(CategoryModel model)
        {
            var searchCategory = _context.CategoryModel.Where(c => c.Name == model.Name).ToList();
            if (searchCategory.Count == 0)
            {
                var category = _context.CategoryModel.Attach(model);
                category.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                return model;
            }
            model.Name = null;
            return model;
        }
    }
}
