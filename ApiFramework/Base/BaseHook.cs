using ApiFramework.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFramework.Base
{
    public class BaseHook
    {
        public void SetupFrameworkSettings(JsonFileReader fileReader)
        {
            fileReader.ReadSettingsFromFile();
        }
    }
}
