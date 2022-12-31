using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpecilisteServiceApi.DbContexts;
using SpecilisteServiceApi.Models;
using SpecilisteServiceApi.Models.Dtos;


namespace SpecilisteServiceApi.Repositories
{
    public class SpecialistRepositoryImpl : SpecialistRepository
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;

        public SpecialistRepositoryImpl(AppDbContext db, IMapper mapper)
        {
                _db = db;
                _mapper = mapper;
        }

        public async Task<SpecialistDto> CreateSpecialist(SpecialistRequestDto request)
        {
            if(request != null)
            {
                Guid UUID = Guid.NewGuid();
                Specialist specialist = _mapper.Map<Specialist>(request);
                specialist.SpecialistID = UUID.ToString();
                _db.Specialists.Add(specialist);
                await _db.SaveChangesAsync();
                Specialist response = await _db.Specialists.Where(p => p.SpecialistID == specialist.SpecialistID).FirstAsync();
                return _mapper.Map<SpecialistDto>(response);
            }
            return null;
        }

        public async Task<ResponseDto> DeleteSpecialist(string id)
        {
            ResponseDto res = new ResponseDto();
            Specialist toDelete = await _db.Specialists.FirstOrDefaultAsync(p => p.SpecialistID == id);
            if(toDelete != null)
            {
                _db.Specialists.Remove(toDelete);
                await _db.SaveChangesAsync();
            }
            else
            {
                res.success = false;
                res.DisplayMessage = "record not found";
                return res;
            }
            
            Specialist delete = await _db.Specialists.Where(p => p.SpecialistID == id).FirstOrDefaultAsync();
            if (delete != null)
            {
                res.success = false;
                res.DisplayMessage = "record not deleted";
                return res;
            }

            res.success = true;
            res.DisplayMessage = "record deleted successfully";
            return res;
        }

        public async Task<SpecialistDto> GetSpecialistById(string id)
        {
            Specialist response = await _db.Specialists.FirstOrDefaultAsync(p => p.SpecialistID == id);
            if(response != null)
            {
                SpecialistDto specialistDto = _mapper.Map<SpecialistDto>(response);
                return specialistDto;
            }
            return null;
        }

        public async Task<IEnumerable<SpecialistDto>> GetSpecialists()
        {
            List<Specialist> list = await _db.Specialists.ToListAsync();
            return _mapper.Map<List<SpecialistDto>>(list);
        }

        public async Task<IEnumerable<SpecialistDto>> SearchSpecialistByName(string name)
        {
            List<Specialist> list = await _db.Specialists.Where(s => s.SpecialistName.ToLower().Contains(name.ToLower())).ToListAsync();
            return _mapper.Map<List<SpecialistDto>>(list);
        }

        public async Task<SpecialistDto> UpdateSpecialist(SpecialistRequestDto request, string id)
        {


            if (request != null)
            {
                Specialist specialist = _mapper.Map<Specialist>(request);
                specialist.SpecialistID = id;
                _db.Specialists.Update(specialist);
                await _db.SaveChangesAsync();
                Specialist response = await _db.Specialists.Where(p => p.SpecialistID == specialist.SpecialistID).FirstAsync();
                return _mapper.Map<SpecialistDto>(response);
            }
            return null;

        }


    }
}
