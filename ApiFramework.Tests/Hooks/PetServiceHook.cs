using ApiFramework.Base;
using ApiFramework.Config;
using ApiFramework.Tests.Service.Pet;
using NUnit.Framework;

namespace ApiFramework.Tests.Hooks
{
    [TestFixture]
    public class PetServiceHook : BaseHook
    {
        protected PetService service;

        [SetUp]
        public void Setup()
        {
            SetupFrameworkSettings(new JsonFileReader());
            service = new PetService();
        }
    }
}