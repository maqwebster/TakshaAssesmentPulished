using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TekshaAssesmentRepo.Models;

namespace TekshaAssesmentRepo.Helper
{
    public static class ValidatorHelper
    {
        /// <summary>
        /// validate method for backend validation 
        /// for validate data come from api call like from postman
        /// or may call api from any other third party app
        /// </summary>
        /// <param name="cvmodel"></param>
        /// <returns></returns>
        public static string Validate(CVModel cvmodel)
        {
            //we can store messages in saperate file as well
            //but due to lack of time i have placed messages over here
            
            if (cvmodel.first_name == string.Empty || cvmodel.first_name.Length > 20)
                return "First name is required and should be 20 characters long max";
            
            if (cvmodel.last_name != null)
            {
                if (cvmodel.last_name.Length > 20)
                    return "Last name should be 20 characters long max";
            }
            if (cvmodel.about_you == string.Empty || cvmodel.about_you.Length > 500)
                return "About you is required and should be 500 characters long max";
            if (cvmodel.cv == string.Empty)
                return "CV is mandatory";
            bool isEmail = Regex.IsMatch(cvmodel.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
                return "Invalid email";
            if (cvmodel.phone_number != null)
            {
                bool isNumber = Regex.IsMatch(cvmodel.phone_number, @"^(?!0+$)[0-9]{1,12}$", RegexOptions.IgnoreCase);
                if (!isNumber)
                    return "Invalid phone number(Max 12 digit only)";
            }
            if (cvmodel.git_profile == string.Empty)
                return "Git profile is required";
            bool isUri = IsUrlValid(cvmodel.git_profile);
            if (!isUri)
                return "Invalid git url";
            return string.Empty;
        }
        /// <summary>
        /// for validate url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsUrlValid(string url)
        {

            string pattern = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(url);
        }
    }
}
