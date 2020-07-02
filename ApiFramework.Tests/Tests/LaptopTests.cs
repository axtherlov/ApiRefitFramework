using System.Threading.Tasks;
using ApiFramework.Tests.Hooks;
using ApiFramework.Tests.Model.Generators;
using NUnit.Framework;

namespace ApiFramework.Tests.Tests
{

    [TestFixture]
    public class LaptopTests : LaptopServiceHook
    {        
        [Test]
        public async Task GetAllLaptops()
        { 
            var response = await service.GetAllLaptops();

            Assert.IsTrue(response.Count >= 1);            
        }

        [Test]
        public async Task GetLaptopById()
        {
            var laptop = await service.CreateLaptop(new LaptopFactory().CreateLaptop());
            var response = await service.GetLaptopById(laptop.Id);

            Assert.AreEqual(laptop.Id, response.Id);
        }

        [Test]
        public async Task CreateLaptop()
        {
            var laptop = new LaptopFactory().CreateLaptop();
            var response = await service.CreateLaptop(laptop);

            Assert.AreEqual(laptop.Id, response.Id);
        }

        [Test]
        public async Task UpdateLaptop()
        {
            var laptop = await service.CreateLaptop(new LaptopFactory().CreateLaptop());
            laptop.BrandName = "Updated Brand";
            laptop.Features.Feature.Add("Sample Feature 3");

            var response = await service.UpdateLaptop(laptop);

            Assert.AreEqual(laptop.BrandName, response.BrandName);
            Assert.AreEqual(laptop.Features.Feature[2], response.Features.Feature[2]);
        }

        [Test]
        public async Task DeleteLaptop()
        {
            var laptop = await service.CreateLaptop(new LaptopFactory().CreateLaptop());
            var response = await service.DeleteLaptop(laptop.Id);

            Assert.AreEqual(laptop.Id, response);
        }
    }
}
