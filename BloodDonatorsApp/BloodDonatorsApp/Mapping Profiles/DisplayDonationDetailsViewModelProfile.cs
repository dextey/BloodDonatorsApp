using AutoMapper;
using BloodDonatorsApp.Models;
using BloodDonatorsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonatorsApp.Validations;
using FluentValidation.Results;
using FluentValidation;

namespace BloodDonatorsApp.Mapping_Profiles
{
    public class DisplayDonationDetailsViewModelProfile : Profile
    {
        public DisplayDonationDetailsViewModelProfile()
        {
            CreateMap<Donation, DisplayDonationDetailsViewModel>();     
        }
    }
}
