using System;
using System.Collections.Generic;
using System.Text;

namespace TekshaAssesmentRepo.Models
{
    public class ResponseModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public CVModel Model { get; set; }
    }
}
