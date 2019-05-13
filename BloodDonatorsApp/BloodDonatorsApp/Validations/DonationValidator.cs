﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using BloodDonatorsApp.Models;


namespace BloodDonatorsApp.Validations
{
    public class DonationValidator : AbstractValidator<Donation>
    {
        public DonationValidator()
        {
            
            RuleFor(donation => donation.First_Name).NotEmpty();
            RuleFor(donation => donation.Last_Name).NotEmpty();
            RuleFor(donation => donation.Pesel).NotEmpty();
            RuleFor(donation => donation.Donation_date).NotEmpty();
            RuleFor(donation => donation.Donated_blood_amount).NotEmpty();
            RuleFor(donation => donation.Blood_type).NotEmpty();
            RuleFor(donation => donation.Blood_factor).NotEmpty();
            RuleFor(donation => donation.Address).NotEmpty();

        }
    }
}
