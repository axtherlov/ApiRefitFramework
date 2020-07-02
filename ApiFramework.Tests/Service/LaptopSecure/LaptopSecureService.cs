using System.Collections.Generic;
using System.Threading.Tasks;
using ApiFramework.Config;
using ApiFramework.Tests.Authorization;
using Refit;

namespace ApiFramework.Tests.Service.LaptopSecure
{
    public class LaptopSecureService
    {
        private ILaptopSecureApi _laptopApi;
        private LaptopAuthorization _authorization;

        public LaptopSecureService()
        {
            _authorization = new LaptopAuthorization();
            _laptopApi = RestService.For<ILaptopSecureApi>(Settings.LaptopSecureBaseUrl, 
                new RefitSettings() { 
                    AuthorizationHeaderValueGetter = ()=> Task.FromResult(_authorization.GetLaptopAuth())
                });            
        }

        public async Task<List<Model.Laptop>> GetAllLaptop()
        {
            return await _laptopApi.GetAllLaptop();
        }
    }
}
