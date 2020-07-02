using System.Collections.Generic;
using System.Threading.Tasks;
using ApiFramework.Config;
using Refit;

namespace ApiFramework.Tests.Service.Laptop
{
    public class LaptopService
    {
        private readonly ILaptopApi _laptopApi;

        public LaptopService()
        {
            _laptopApi = RestService.For<ILaptopApi>(Settings.LaptopBaseUrl);
        }

        public async Task<List<Model.Laptop>> GetAllLaptops()
        {
            return await _laptopApi.GetLaptop();
        }

        public async Task<Model.Laptop> GetLaptopById(int id)
        {
            return await _laptopApi.GetLaptop(id);
        }

        public async Task<Model.Laptop> CreateLaptop(Model.Laptop laptop)
        {
            return await _laptopApi.CreateLaptop(laptop);
        }

        public async Task<Model.Laptop> UpdateLaptop(Model.Laptop laptop)
        {
            return await _laptopApi.UpdateLaptop(laptop);
        }

        public async Task<int> DeleteLaptop(int id)
        {
            return await _laptopApi.DeleteLaptop(id);
        }
    }
}
