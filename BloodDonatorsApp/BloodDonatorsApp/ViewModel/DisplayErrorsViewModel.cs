using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonatorsApp.ViewModel
{
    public class DisplayErrorsViewModel
    {
        public DisplayDonationDetailsViewModel Details { get; set; }
        public FluentValidation.Results.ValidationResult Result { get; set; }
    }
}
