
using System.Net.Http;

namespace ApiFramework.Config
{
    public class Settings
    {
        public static string LaptopBaseUrl { get; set; }
        public static string LaptopSecureBaseUrl { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string PetBaseUrl { get; set; }
        public static string ClientId { get; set; }
        public static string ClientSecret { get; set; }
    }
}
