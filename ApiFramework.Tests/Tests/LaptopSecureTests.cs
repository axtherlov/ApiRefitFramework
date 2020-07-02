using System.Threading.Tasks;
using ApiFramework.Tests.Hooks;
using NUnit.Framework;

namespace ApiFramework.Tests.Tests
{
    [TestFixture]
    public class LaptopSecureTests : LaptopSecureServiceHook
    {
        [Test]
        public async Task GetAllLaptop()
        {
            var response = await service.GetAllLaptop();

            Assert.IsTrue(response.Count > 1);
        }
    }
}
