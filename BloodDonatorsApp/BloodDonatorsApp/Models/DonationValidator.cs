using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace BloodDonatorsApp.Models
{
    public class DonationValidator : AbstractValidator<Donation>
    {
        public DonationValidator()
        {
            //TODO: Create tests for these validations
            RuleFor(donation => donation.First_Name).NotEmpty().MaximumLength(12);
            RuleFor(donation => donation.Last_Name).NotEmpty().MaximumLength(16);
            RuleFor(donation => donation.Pesel).NotEmpty();
            RuleFor(donation => donation.Donation_date).NotEmpty();
            RuleFor(donation => donation.Donated_blood_amount).NotEmpty();
            RuleFor(donation => donation.Blood_type).NotEmpty().MaximumLength(1);
            RuleFor(donation => donation.Blood_factor).NotEmpty().MaximumLength(3);
            RuleFor(donation => donation.Address).NotEmpty();

        }
    }
}
