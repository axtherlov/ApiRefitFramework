using System.Threading.Tasks;
using ApiFramework.Tests.Model;
using Refit;

namespace ApiFramework.Tests.Service.Pet
{
    interface IPetApi
    {
        [Get("/animals/{id}")]
        [Headers("Authorization: Bearer")]
        Task<AnimalCollection> GetAnimal([AliasAs("id")] int id);
    }
}
