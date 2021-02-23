using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(3);

            RuleFor(u => u.FirstName).Must(StartWithA).WithMessage("Kullanıcı adı A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
           return arg.StartsWith("A");
        }
    }
}
