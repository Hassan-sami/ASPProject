using Booking.viewModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.customValidate
{
    public class DateCompareAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            BookFlightViewModel model = (BookFlightViewModel)validationContext.ObjectInstance;
            if(model.ReturningDate == DateTime.MinValue)
            {
                model.TypeOfTrip = TypeOfTrip.OneWayTrip;
            }
            if(model.TypeOfTrip == TypeOfTrip.RoundTrip)
            {
                DateTime date = (DateTime)value ;
                if (date.Year < model.DepartingDate.Year)
                {
                    return new ValidationResult("the returning date is earlier than departing date or at the same date");

                }else if(date.Year > model.DepartingDate.Year)
                {
                    return ValidationResult.Success;
                }


                if (date.Month < model.DepartingDate.Month)
                {
                    return new ValidationResult("the returning date is earlier than departing date or at the same date");
                }
                else if (date.Month > model.DepartingDate.Month)
                {
                    return ValidationResult.Success;
                }


                if (date.Day <= model.DepartingDate.Day)
                {
                    return new ValidationResult("the returning date is earlier than departing date or at the same date");
                }
                else 
                {
                    return ValidationResult.Success;
                }


                


            }
            else if(model.TypeOfTrip == TypeOfTrip.OneWayTrip)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Error");
            }
               
            
        }

    }



    public class DateCompareHotelAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            BookHotelViewModel model = (BookHotelViewModel)validationContext.ObjectInstance;

                DateTime date = (DateTime)value;
                if (date.Year < model.CheckIn.Year)
                {
                    return new ValidationResult("the CheckOut date is earlier than CheckIn date or at the same date");

                }
                else if (date.Year > model.CheckIn.Year)
                {
                    return ValidationResult.Success;
                }


                if (date.Month < model.CheckIn.Month)
                {
                    return new ValidationResult("the CheckOut date is earlier than CheckIn date or at the same date");
                }
                else if (date.Month > model.CheckIn.Month)
                {
                    return ValidationResult.Success;
                }

                if (date.Day <= model.CheckIn.Day)
                {
                    return new ValidationResult("the CheckOut date is earlier than CheckIn date or at the same date");
                }
                else
                {
                    return ValidationResult.Success;
                }





          

        }

    }

}
