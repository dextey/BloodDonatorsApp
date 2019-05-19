using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using BloodDonatorsApp.ViewModel;
using BloodDonatorsApp.Models;
using AutoMapper;
using BloodDonatorsApp.Validations;

namespace BloodDonatorsApp.Controllers
{
    public class DonationsController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly IMapper _mapper;
        public static string csvFileUniqueName;
      

        public DonationsController(IHostingEnvironment env, IMapper mapper)
        {
            _env = env;
            _mapper = mapper;
        }

        public IActionResult Create()
        {
            return View(new AddCsvViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddCsvViewModel addCsvViewModel)
        {
            try
            {
                if(addCsvViewModel.Csv != null)
                {
       
                    var destinationFolder = Path.Combine(_env.WebRootPath, "data");
                    var filePath = Path.Combine(destinationFolder, addCsvViewModel.Csv.FileName);
                    var fileStream = new FileStream(filePath, FileMode.Create);
                    addCsvViewModel.Csv.CopyTo(fileStream);

                    //dispose of file stream object
                    fileStream.Dispose();
                    
                    csvFileUniqueName = addCsvViewModel.Csv.FileName;

                    return RedirectToAction("Index", "Donations");
                }
                return View(addCsvViewModel);
            }
            catch 
            {

            return View();
                
            }

        }

        public IActionResult Index()
        {
            
            string dataFolder = "data";
            string csvFilePath = Path.Combine(_env.WebRootPath, dataFolder, csvFileUniqueName);
            IEnumerable<Donation> dataRecords;
            IEnumerable<DisplayDonationDetailsViewModel> displayDonationDetails;

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader))
            {
                dataRecords = csv.GetRecords<Donation>().ToList();

            }

            //Performing automapping
            displayDonationDetails = _mapper.Map<IEnumerable<DisplayDonationDetailsViewModel>>(dataRecords);

            
            List<FluentValidation.Results.ValidationResult> resultsList = new List<FluentValidation.Results.ValidationResult>();
            List<bool> validList = new List<bool>();
            List<DisplayErrorsViewModel> displayErrors = new List<DisplayErrorsViewModel>();

            foreach (var item in displayDonationDetails)
            {
                DisplayDonationDetailsViewModel details = item;
                DisplayDonationDetailsValidator validator = new DisplayDonationDetailsValidator();
                resultsList.Add(validator.Validate(details));
                validList.Add(validator.Validate(details).IsValid);
                displayErrors.Add(new DisplayErrorsViewModel { Details = item, Result = validator.Validate(details) });
                
            }

           if (validList.Contains(false))
            {
                return PartialView("_ValidationResults", displayErrors);
            }
            
            return View(displayDonationDetails);
        }

        public ActionResult ShowDetails(DisplayDonationDetailsViewModel display)
        {
            return PartialView("_Details", display);
        }
    }
}