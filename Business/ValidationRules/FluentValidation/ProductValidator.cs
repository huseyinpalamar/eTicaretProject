using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(P => P.ProductName).NotEmpty();
            RuleFor(p=> p.ProductName).NotNull();
            // aralara kurallar koyabiliriz.
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(2);
            // must ile kendi kuralını koy
            
            

        }

        
    }
}
