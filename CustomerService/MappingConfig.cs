using AutoMapper;
using CustomerService.Models;
using CustomerService.Models.Dtos;

namespace CustomerService
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Customer, CustomerDto>().ReverseMap();
                config.CreateMap<CustomerRequestDto, Customer>().ReverseMap();
                config.CreateMap<Offer, OfferRequestDto>().ReverseMap();
                config.CreateMap<Offer, OfferDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
