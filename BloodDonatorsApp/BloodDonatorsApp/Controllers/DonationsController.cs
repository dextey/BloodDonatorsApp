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
            IEnumerable<DisplayDonationDetailsViewModel> displayDonationDetails;



            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader))
            {
                dataRecords = csv.GetRecords<Donation>().ToList();

            }


            //Performing automapping

            displayDonationDetails = _mapper.Map<IEnumerable<DisplayDonationDetailsViewModel>>(dataRecords);

            List<bool> resultsList = new List<bool>();

            foreach (var item in displayDonationDetails)
            {
                DisplayDonationDetailsViewModel details = item;
                DisplayDonationDetailsValidator validator = new DisplayDonationDetailsValidator();
                resultsList.Add(validator.Validate(details).IsValid);
                
            }

           if (resultsList.Contains(false))
            {
                return View("Index");
            }
            
            return View(displayDonationDetails);
        }

        public ActionResult ShowDetails(DisplayDonationDetailsViewModel display)
        {
            return PartialView("_Details", display);
        }
    }
}