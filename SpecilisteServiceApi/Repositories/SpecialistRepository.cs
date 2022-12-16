using SpecilisteServiceApi.Models.Dtos;

namespace SpecilisteServiceApi.Repositories
{
    public interface SpecialistRepository
    {
        Task<SpecialistDto> GetSpecialistById(string id);
        Task<IEnumerable<SpecialistDto>> GetSpecialists();
        Task<IEnumerable<SpecialistDto>> SearchSpecialistByName(string name);
        Task<SpecialistDto> CreateSpecialist(SpecialistRequestDto request);
        Task<ResponseDto> DeleteSpecialist(string id);
        Task<SpecialistDto> UpdateSpecialist(SpecialistRequestDto request, string id);

    }
}
