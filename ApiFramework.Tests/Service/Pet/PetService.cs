using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using ApiFramework.Config;
using ApiFramework.Tests.Authorization;
using ApiFramework.Tests.Model;
using Refit;

namespace ApiFramework.Tests.Service.Pet
{
    public class PetService
    {
        private IPetApi _petApi;
        private PetAuthorization _authorization;

        public PetService()
        {
            _authorization = new PetAuthorization();

            _petApi = RestService.For<IPetApi>(new HttpClient(new AuthenticatedHttpClientHandler(GetToken))
            {
                BaseAddress = new Uri(Settings.PetBaseUrl)
            });
        }

        private async Task<string> GetToken()
        {
            var token = await _authorization.GetPetAuthToken();        
            return token.AccessToken;
        }

        public async Task<Animal> GetAnimalById(int id)
        {
            var animals =  await _petApi.GetAnimal(id);
            return animals.Animal;
        }
    }

    class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<string>> getToken;
        public AuthenticatedHttpClientHandler(Func<Task<string>> getToken)
        {
            if (getToken == null) throw new ArgumentNullException(nameof(getToken));
            this.getToken = getToken;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            if (auth != null)
            {
                var token = await getToken().ConfigureAwait(false);
                request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, token);
            }
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
