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
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A ile başlamalı");
            

        }

        private bool StartWithA(string arg)
        {
            // a ile başlamalı . A ile başlamıyorsa false döner. A ile başlarsa true döner 
            return arg.StartsWith("A");
        }
    }
}
