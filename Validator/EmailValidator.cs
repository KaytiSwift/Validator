using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    public class EmailValidator
    {
        public ValidationResult IsValid(string input)
        {
            var result = new ValidationResult()
            {
                IsValid = true,
                ErrorMessages = new List<string>()
            };

            if (input == "")
            {
                //var x = new ValidationResult();
                //x.IsValid = false;
                //return x;
                result.IsValid = false;
                result.ErrorMessages.Add("Email is required.");
            };

            return result;
            
        }
    }
}
