using System.Threading.Tasks;
using ApiFramework.Tests.Hooks;
using NUnit.Framework;

namespace ApiFramework.Tests.Tests
{
    [TestFixture]
    public class PetTests: PetServiceHook
    {
        [Test]
        public async Task GetAnimalById()
        {
            var animal = await service.GetAnimalById(47891595);
            Assert.AreEqual(animal.Id, 47891595);
        }
    }
}
