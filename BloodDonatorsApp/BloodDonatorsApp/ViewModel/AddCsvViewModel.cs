using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonatorsApp.ViewModel;
using Microsoft.AspNetCore.Http;

namespace BloodDonatorsApp.ViewModel
{
    public class AddCsvViewModel
    {
        public IFormFile Csv { get; set; }
    }
}
