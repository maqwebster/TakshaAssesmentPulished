using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TekshaAssesmentRepo.Models
{
    public class CVModel 
    {
        public CVModel()
        {
            //default initialization
            //for prevent null exception while validating or 
            //accessing null property
            this.first_name = string.Empty;
            this.last_name = string.Empty;
            this.about_you = string.Empty;
            this.phone_number = string.Empty;
            this.email = string.Empty;
            this.git_profile = string.Empty;
            this.cv = string.Empty;
            this.cover_letter = string.Empty;
        }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public bool live_in_us { get; set; }
        public string git_profile { get; set; }
        public string cv { get; set; }
        public string cover_letter { get; set; }
        public string about_you { get; set; }
    }
}
