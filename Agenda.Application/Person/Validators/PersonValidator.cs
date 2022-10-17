using Agenda.Application.Person.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Person.Validators
{
    public class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithName("Invalid-name")
                .WithMessage("Invalid e-mail address");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithName("Invalid-name")
                .WithMessage("Invalid FirstName");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithName("Invalid-name")
                .WithMessage("Invalid LastName");

            RuleFor(x => x.PhoneNumber)
                .Length(10)
                .WithMessage("Invalid PhoneNumber");


        }
    }
}
