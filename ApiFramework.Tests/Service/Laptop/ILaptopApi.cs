using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFramework.Tests.Service.Laptop
{
    [Headers("Accept: application/json")]
    public interface ILaptopApi
    {
        [Get("/all")]
        Task<List<Model.Laptop>> GetLaptop();

        [Get("/find/{id}")]
        Task<Model.Laptop> GetLaptop([AliasAs("id")] int id);

        [Post("/add")]
        Task<Model.Laptop> CreateLaptop([Body] Model.Laptop laptop);

        [Put("/update")]
        Task<Model.Laptop> UpdateLaptop([Body] Model.Laptop laptop);

        [Delete("/delete/{id}")]
        [Headers("Accept: */*" )]
        Task<int> DeleteLaptop([AliasAs("id")] int id);
    }
}
