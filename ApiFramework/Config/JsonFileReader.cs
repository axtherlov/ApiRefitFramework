using Microsoft.Extensions.Configuration;
using System;

namespace ApiFramework.Config
{
    public class JsonFileReader
    {
        public IConfigurationRoot SetupFileReader(string settingsFile)
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.SetupInformation.ApplicationBase)
                .AddJsonFile(settingsFile)
                .Build();
        }

        public void ReadSettingsFromFile()
        {
            var testSettings = SetupFileReader("appSettings.json")
                                        .GetSection("configuration")
                                        .Get<TestSettings>();
            Settings.LaptopBaseUrl = testSettings.LaptopBaseUrl;
            Settings.LaptopSecureBaseUrl = testSettings.LaptopSecureBaseUrl;
            Settings.Username = testSettings.Username;
            Settings.Password = testSettings.Password;
            Settings.PetBaseUrl = testSettings.PetBaseUrl;
        }
    }
}
