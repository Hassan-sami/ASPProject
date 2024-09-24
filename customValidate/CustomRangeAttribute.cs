using Booking.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace Booking.customValidate
{
    public class CustomRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            

            Room Room = validationContext.ObjectInstance as Room;

            if (Room == null)
            {
                
                return new ValidationResult("this object is not Room"); ;
            }
            if(Room.BedNo == (int)value)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("the number of beds does not equal number of resident"); 
        }
    }

         
    }

