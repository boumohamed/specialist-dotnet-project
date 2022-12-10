using SpecilisteServiceApi.Models.Dtos;

namespace SpecilisteServiceApi.Repositories
{
    public interface SpecialistRepository
    {
        Task<SpecialistDto> GetSpecialistById(string id);
        Task<IEnumerable<SpecialistDto>> GetSpecialists();
        Task<SpecialistDto> CreateSpecialist(SpecialistRequestDto request);
        Task<bool> DeleteSpecialist(string id);

    }
}
