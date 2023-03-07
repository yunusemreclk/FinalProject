﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.CustomerId).NotEmpty();
            RuleFor(c=>c.CustomerId).MinimumLength(3);
            RuleFor(c=>c.ContactName).NotEmpty();
            RuleFor(c=>c.City).NotEmpty();
        }
    }
}
