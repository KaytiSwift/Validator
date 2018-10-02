using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; }
    }

   
}
