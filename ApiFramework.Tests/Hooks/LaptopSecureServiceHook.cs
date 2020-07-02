using ApiFramework.Base;
using ApiFramework.Config;
using ApiFramework.Tests.Service.LaptopSecure;
using NUnit.Framework;

namespace ApiFramework.Tests.Hooks
{
    [TestFixture]
    public class LaptopSecureServiceHook : BaseHook
    {
        protected LaptopSecureService service;

        [SetUp]
        public void SetUp()
        {
            SetupFrameworkSettings(new JsonFileReader());
            service = new LaptopSecureService();
        }
    }
}
