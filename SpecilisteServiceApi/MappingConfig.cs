using AutoMapper;
using SpecilisteServiceApi.Models;
using SpecilisteServiceApi.Models.Dtos;

namespace SpecilisteServiceApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Specialist, SpecialistDto>().ReverseMap();
                config.CreateMap<SpecialistRequestDto, Specialist>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
