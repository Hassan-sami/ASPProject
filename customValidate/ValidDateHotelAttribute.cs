using Booking.viewModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.customValidate
{
    public class ValidDateHotelAttribute : ValidationAttribute
    {


        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            BookHotelViewModel model = (BookHotelViewModel)validationContext.ObjectInstance;

            DateTime date = (DateTime)value;
            if (date.Year < DateTime.Now.Year)
            {
                return new ValidationResult("the CheckIn date is in the past choose anthor date");

            }
            else if (date.Year > DateTime.Now.Year)
            {
                return ValidationResult.Success;
            }


            if (date.Month < DateTime.Now.Month)
            {
                return new ValidationResult("the CheckIn date is in the past choose anthor date");

            }
            else if (date.Month > DateTime.Now.Month)
            {
                return ValidationResult.Success;
            }


            if (date.Day < DateTime.Now.Day)
            {
                return new ValidationResult("the CheckIn date is in the past choose anthor date");
            }
            else if (date.Day > DateTime.Now.Day)
            {
                return ValidationResult.Success;
            }
            else
            {
                return ValidationResult.Success;
            }




        }

    }

}
