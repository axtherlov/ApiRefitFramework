using System;
using System.Text;
using ApiFramework.Config;

namespace ApiFramework.Tests.Authorization
{
    public class LaptopAuthorization
    {
        public string GetLaptopAuth()
        {
           return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                                                 .GetBytes(Settings.Username + ":" + Settings.Password));           
        }
    }
}
