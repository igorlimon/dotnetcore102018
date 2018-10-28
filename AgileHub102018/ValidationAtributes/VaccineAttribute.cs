using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgileHub102018.ValidationAtributes
{
    public class VaccineAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = value as List<string>;
            if (list == null)
            {
                return false;
            }

            return list.Any(l => l.Equals("R345"));
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }
    }
}
