using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using BloodDonatorsApp.ViewModel;
using BloodDonatorsApp.Models;
using BloodDonatorsApp.Mapping_Profiles;
using AutoMapper;
using BloodDonatorsApp.Validations;
using FluentValidation.Results;

namespace BloodDonatorsApp.Controllers
{
    public class DonationsController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly IMapper _mapper;
        public DonationsController(IHostingEnvironment env, IMapper mapper)
        {
            _env = env;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            string webRootPath = _env.WebRootPath;
            string dataFolder = "data";
            string fileName = "MOCK_DATA.csv";
            string csvFilePath = Path.Combine(webRootPath, dataFolder, fileName);
            IEnumerable<Donation> dataRecords;
            IEnumerable<DisplayDonatorViewModel> displayDonatorViewModels;
            


            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader))
            {
                dataRecords = csv.GetRecords<Donation>().ToList();
                
            }

            
            //Performing automapping
            displayDonatorViewModels = _mapper.Map<IEnumerable<DisplayDonatorViewModel>>(dataRecords);

            //instantiating validator object and quick check on data validation
            Donation donation = dataRecords.First();
            DonationValidator validator = new DonationValidator();

            ValidationResult results = validator.Validate(donation);

            return View(displayDonatorViewModels);
        }
    }
}