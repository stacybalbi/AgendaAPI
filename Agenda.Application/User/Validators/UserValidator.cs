using Agenda.Application.User.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.User.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).EmailAddress().WithName("Invalid-name")
                .WithMessage("Debe ingresar un correo válido")
                .WithSeverity(Severity.Error)
                .WithErrorCode("405rptm");

            RuleFor(x => x.PhoneNumber).Length(10)
                .WithMessage("Debe ingresar un numero telefonico con 10 digitos");
            RuleFor(x => x.UserName).MinimumLength(5).Must(x => x.Contains("0"));
        }
    }
}
