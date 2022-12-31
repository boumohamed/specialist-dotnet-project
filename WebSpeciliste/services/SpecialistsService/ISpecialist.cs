using WebSpeciliste.Models;

namespace WebSpeciliste.services.SpecialistsService
{
    public interface ISpecialist : IBaseService
    {
        Task<T> GetAllSpecialistsAsync<T>();
        Task<T> GetOneSpecialistByIdAsync<T>(string id, string accessToken);
        Task<T> CreateSpecialistAsync<T>(SpecialistDto specialist, string accessToken);
        Task<T> UpdateSpecialistAsync<T>(string id, SpecialistDto specialist, string accessToken);
        Task<T> DeleteSpecialistAsync<T>(string id, string accessToken);
        Task<T> SeachSpecialistByNameAsync<T>(string name, string accessToken);

    }
}
