using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using TekshaAssesmentRepo.Interfaces;
using TekshaAssesmentRepo.Models;

namespace TekshaAssesmentRepo.Repositories
{
    public class CVRepo : ICV
    {
        #region Declaration
        string folderName = "CVs";
        #endregion
        public bool saveCV(CVModel cvmodel)
        {
            
            string json = JsonSerializer.Serialize(cvmodel);
            try
            {
                //save candidate details to directory in json format
                string path = Directory.GetCurrentDirectory();
                File.WriteAllText(@path+"\\wwwroot\\"+ folderName + "\\"+ cvmodel.email+"\\" + cvmodel.email + ".json", json);
                //for storing details in db we can use here dbContext 
                //object to save entity according to table entity
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
