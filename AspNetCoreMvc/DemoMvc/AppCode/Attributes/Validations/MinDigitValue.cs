using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMvc.AppCode.Attributes.Validations
{
	public class MinDigitValue : ValidationAttribute
	{
		public MinDigitValue()
		{
		}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}

