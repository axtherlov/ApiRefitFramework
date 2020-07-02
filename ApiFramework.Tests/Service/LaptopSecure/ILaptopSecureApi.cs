using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace ApiFramework.Tests.Service.LaptopSecure
{
    [Headers("Accept: application/json", "Authorization: Basic")]
    interface ILaptopSecureApi
    {
        [Get("/all")]
        Task<List<Model.Laptop>> GetAllLaptop();
    }
}
