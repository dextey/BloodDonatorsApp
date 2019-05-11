using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using BloodDonatorsApp.ViewModel;

namespace BloodDonatorsApp.Validations
{
    public class DisplayDonatorViewModelValidator : AbstractValidator<DisplayDonatorViewModel>
    {
        public DisplayDonatorViewModelValidator()
        {
            RuleFor(donator => donator.First_Name).NotEmpty();
            RuleFor(donator => donator.Last_Name).NotEmpty();
            RuleFor(donator => donator.Donated_blood_amount).NotEmpty();

        }
    }
}
