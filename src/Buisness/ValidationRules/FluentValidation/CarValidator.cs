using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            // c=Car
            //RuleFor(c => c.Brand).NotEmpty();
            //RuleFor(c => c.Color).NotEmpty();
            //RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.DailyPrice).NotEmpty(); 
            //RuleFor(c => c.Description).NotEmpty();
        }
    }
}
