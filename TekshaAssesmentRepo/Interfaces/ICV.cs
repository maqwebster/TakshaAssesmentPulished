using System;
using System.Collections.Generic;
using System.Text;
using TekshaAssesmentRepo.Models;

namespace TekshaAssesmentRepo.Interfaces
{
    public interface ICV
    {
        public bool saveCV(CVModel cvmodel);
    }
}
