using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AutoMapper;
using BloodDonatorsApp.Mapping_Profiles;
using BloodDonatorsApp.ViewModel;
using BloodDonatorsApp.Models;

namespace Tests
{
    
    public class DisplayDonatorMapperTester
    {
       
        [SetUp]
        public void Setup()
        {
            Mapper.Initialize(cfg =>
            cfg.CreateMap<Donation, DisplayDonatorViewModel>());
        }

        [Test]
        public void ShouldHaveErrorWhenMappingIsNotValid()
        {
            Mapper.AssertConfigurationIsValid();
            Mapper.Reset();
        }
    }

    public class DisplayDonationDetailsMapperTester
    {

        [SetUp]
        public void Setup()
        {
            Mapper.Initialize(cfg =>
            cfg.CreateMap<Donation, DisplayDonationDetailsViewModel>());
        }

        [Test]
        public void ShouldHaveErrorWhenMappingIsNotValid()
        {
            Mapper.AssertConfigurationIsValid();
            Mapper.Reset();
        }
    }
}
