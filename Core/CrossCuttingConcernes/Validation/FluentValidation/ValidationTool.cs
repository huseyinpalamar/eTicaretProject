using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcernes.Validation.FluentValidation
{
    public static class ValidationTool
    {


        public static void Validate(IValidator validatör,object entity)
        {
            var context = new ValidationContext<object>(entity);

            var result =validatör.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);

            }
        }
    }
}
