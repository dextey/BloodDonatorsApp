﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonatorsApp.Models
{
    public class Donation
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public long Pesel { get; set; }
        public string Donation_date { get; set; }
        public string Donated_blood_amount { get; set; }
        public string Blood_type { get; set; }
        public string Blood_factor { get; set; }
        public string Address { get; set; }
    }
}
