using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApp.Models
{
    public class CategoryModel
    {
        [Key]
        public int Cid { get; set; }
        [Required(ErrorMessage = "Please enter the category name")]
        public string Name { get; set; }
    }
}
