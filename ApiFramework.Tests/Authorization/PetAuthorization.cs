using ApiFramework.Config;
using ApiFramework.Tests.Service.Pet;
using Refit;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.Tests.Authorization
{
    public class PetAuthorization
    {
        private IPetAuthApi _petAuthApi;
        private MyQueryParams _params;

        public PetAuthorization()
        {
            _params = new MyQueryParams();
            _petAuthApi = RestService.For<IPetAuthApi>(Settings.PetBaseUrl, 
                new RefitSettings() { 
                    AuthorizationHeaderValueGetter = ()=> Task.FromResult(GetAuthBase64())
                });           
        }

        private string GetAuthBase64()
        {
            return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                .GetBytes("1nckBucICxtLySSOGtUW7vSGRNXwBU8NTXzf0EdFxWh4gWecYm" + ":" + "uSRQFlX6k6GsXWbHMyvPjvdWgA7vvXXbqCE8VsSz"));           
        }

        public async Task<Auth> GetPetAuthToken()
        {
            return await _petAuthApi.GetOAuthToken(_params);
        }
    }
}
