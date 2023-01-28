
using WebSpeciliste.Models;
using WebSpeciliste.services.SpecialistsService;

namespace WebSpeciliste.services.CustomerServices
{
    public interface ICustomer : IBaseService
    {
        Task<T> GetAllCustomersAsync<T>();
        Task<T> GetOneCustomerByIdAsync<T>(string id);
        Task<T> RegisterAsync<T>(SpecialistDto specialist);
        Task<T> UpdateProfileAsync<T>(string id, SpecialistDto specialist);
        Task<T> SeachCustomerByNameAsync<T>(string name);
        Task<T> GetCustomerOffersAsync<T>(string id);
        Task<T> CreateOfferAsync<T>(OfferDto offer);
        Task<T> UpdateOfferAsync<T>(string id);
        Task<T> GetOneOfferAsync<T>(string id);
        Task<T> GetOfferByLocationSpecialityKeywordAsync<T>(string speciality, string location, string keyword);

    }
}
