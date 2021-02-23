using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorsValidator:AbstractValidator<Color>
    {
        public ColorsValidator()
        {

            RuleFor(c => c.ColorName).Must(StartWithE).WithMessage("ürünler E harfi ile başlamalı");
        
        }

        private bool StartWithE(string arg)
        {
            return arg.StartsWith("E");
        }
    }
}
