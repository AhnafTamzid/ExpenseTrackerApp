using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApp.Models
{
    public class CustomDateValidator : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "Date Entry can't be a future date";
        }
        protected override ValidationResult IsValid(object objValue,
                                                   ValidationContext validationContext)
        {
            DateTime dateValue = Convert.ToDateTime(objValue);

            if (dateValue.Date > DateTime.Now.Date)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}
