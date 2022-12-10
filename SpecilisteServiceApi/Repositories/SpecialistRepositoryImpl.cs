using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpecilisteServiceApi.DbContexts;
using SpecilisteServiceApi.Models;
using SpecilisteServiceApi.Models.Dtos;
using System.Collections.Generic;
using System.Net;

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
                _db.SaveChanges();
                Specialist response = await _db.Specialists.Where(p => p.SpecialistID == specialist.SpecialistID).FirstAsync();
                return _mapper.Map<SpecialistDto>(response);
            }
            return null;

        }

        public async Task<bool> DeleteSpecialist(string id)
        {
            bool deleted = true;
            Specialist response = await _db.Specialists.Where(p => p.SpecialistID == id).FirstOrDefaultAsync();
            if(response != null)
            {
                _db.Specialists.Remove(response);
                _db.SaveChanges();
            }
            
            Specialist delete = await _db.Specialists.Where(p => p.SpecialistID == id).FirstOrDefaultAsync();
            if (delete != null)
                deleted = false;

            return deleted;


        }

        public async Task<SpecialistDto> GetSpecialistById(string id)
        {
            Specialist response = await _db.Specialists.Where(p => p.SpecialistID == id).FirstOrDefaultAsync();
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
    }
}
