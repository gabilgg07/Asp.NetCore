using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMvc.AppCode.Attributes.Validations
{
	public class RequiredForeignKeyAttribute : RequiredAttribute
	{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {


            if (!int.TryParse(value.ToString(), out int id))
            {
                return new ValidationResult($"Melumat doldurulmayib");
            }
            if (id <= 0)
            {
                return new ValidationResult($"Uygun deyer deyil");
            }

            return ValidationResult.Success;
        }
    }
}

