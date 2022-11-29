using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMvc.AppCode.Attributes.Validations
{
	public class GratherThan18Attribute : RequiredAttribute
	{

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!int.TryParse(value.ToString(), out int age))
            {
                return new ValidationResult($"Melumat doldurulmayib");
            }
            if (age < 1)
            {
                return new ValidationResult($"Uygun deyer deyil");
            }
            if (age < 18)
            {
                return new ValidationResult($"Yas heddi 17-den yuksek olmalidir");
            }

            return ValidationResult.Success;
        }
    }
}

