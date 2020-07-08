using System.Threading.Tasks;
using ApiFramework.Tests.Authorization;
using Newtonsoft.Json;
using Refit;

namespace ApiFramework.Tests.Service.Pet
{
    interface IPetAuthApi
    {
        [Headers("Accept: application/json", "Authorization: Basic", "Content-Type: application/x-www-form-urlencoded")]
        [Post("/oauth2/token")]
        Task<Auth> GetOAuthToken([Body(BodySerializationMethod.UrlEncoded)] MyQueryParams queryParams);
    }

    public class MyQueryParams
    {
        public string grant_type { get; set; } = "client_credentials";
    }

    public class Auth
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
