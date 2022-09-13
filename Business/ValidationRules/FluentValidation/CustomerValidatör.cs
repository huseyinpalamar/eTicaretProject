using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidatör:AbstractValidator<Customer>
    {

        public CustomerValidatör()
        {
            RuleFor(c=>c.CompanyName).NotEmpty();
            RuleFor(c=>c.CompanyName).NotNull();
            RuleFor(c=>c.City).NotNull().NotEmpty();
            RuleFor(c=>c.ContactName).NotNull().NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(5);
            RuleFor(c => c.ContactName).MinimumLength(5);

        }
    }
}
