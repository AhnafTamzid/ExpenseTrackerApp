using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApp.Models
{
    public class ExpenseModel
    {
        [Key]
        public int Eid { get; set; }

        [StringLength(10,MinimumLength =10,ErrorMessage = "Please enter correct date")]
        [Required(ErrorMessage = "Please select the date")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Please enter the amount")]
        public int? Amount { get; set; }
        public string? Category { get; set; }

        [Display(Name ="Category")]
        [Required(ErrorMessage = "Please choose category")]
        public int? CategoryId { get; set; }
    }
}
