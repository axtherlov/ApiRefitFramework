using ApiFramework.Base;
using ApiFramework.Config;
using ApiFramework.Tests.Service.Laptop;
using NUnit.Framework;

namespace ApiFramework.Tests.Hooks
{
    [TestFixture]
    public class LaptopServiceHook : BaseHook
    {
        protected LaptopService service;

        [SetUp]
        public void SetUp()
        {
            SetupFrameworkSettings(new JsonFileReader());
            service = new LaptopService();
        }
    }
}
