using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using BloodDonatorsApp.Models;

namespace BloodDonatorsApp.Controllers
{
    public class DonationsController : Controller
    {
        private readonly IHostingEnvironment _env;
        public DonationsController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            string webRootPath = _env.WebRootPath;
            string dataFolder = "data";
            string fileName = "MOCK_DATA.csv";
            string csvFilePath = Path.Combine(webRootPath, dataFolder, fileName);
            //TODO: Do something lol
            //TODO: Initiliaze AutoMapper configuration
            using (var reader = new StreamReader(csvFilePath))
            using(var csv = new CsvReader(reader))
            {
                var dataRecords = csv.GetRecords<Donation>();
            }
            return View();
        }
    }
}