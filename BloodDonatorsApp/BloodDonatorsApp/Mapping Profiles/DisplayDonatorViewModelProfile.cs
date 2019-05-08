using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BloodDonatorsApp.Models;
using BloodDonatorsApp.ViewModel;

namespace BloodDonatorsApp.Mapping_Profiles
{
    public class DisplayDonatorViewModelProfile : Profile
    {
        public DisplayDonatorViewModelProfile()
        {
            //TODO: Create mapping tests
            CreateMap<Donation, DisplayDonatorViewModel>()
                .ForMember(destination => destination.First_Name, handler => handler.MapFrom(source => source.First_Name))
                .ForMember(destination => destination.Last_Name, handler => handler.MapFrom(source => source.Last_Name))
                .ForMember(destination => destination.Donated_blood_amount, handler => handler.MapFrom(source => source.Donated_blood_amount));
                
                
            
        }
    }
}
