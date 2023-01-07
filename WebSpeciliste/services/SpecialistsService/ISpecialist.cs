using WebSpeciliste.Models;

namespace WebSpeciliste.services.SpecialistsService
{
    public interface ISpecialist : IBaseService
    {
        Task<T> GetAllSpecialistsAsync<T>();
        Task<T> GetOneSpecialistByIdAsync<T>(string id);
        Task<T> CreateSpecialistAsync<T>(SpecialistDto specialist);
        Task<T> UpdateSpecialistAsync<T>(string id, SpecialistDto specialist);
        Task<T> DeleteSpecialistAsync<T>(string id);
        Task<T> SeachSpecialistByNameAsync<T>(string name);

    }
}
