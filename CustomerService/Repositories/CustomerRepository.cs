using CustomerService.Models.Dtos;
using CustomerService.Models;


namespace CustomerService.Repositories
{
    public interface CustomerRepository
    {
        Task<Customer> GetCustomerById(string id);
        Task<IEnumerable<CustomerDto>> GetCustomers();
        Task<IEnumerable<CustomerDto>> SearchCustomerByName(string name);
        Task<CustomerDto> CreateCustomer(CustomerRequestDto request);
        Task<ResponseDto> DeleteCustomer(string id);
        Task<CustomerDto> UpdateCustomer(CustomerRequestDto request, string id);

        Task<ResponseDto> CreateOffer(string customerId, OfferRequestDto request);


        Task<IEnumerable<OfferDto>> GetOffersByCustomer(string id);
        Task<IEnumerable<Offer>> GetOffers(string id);
        /*
        Task<IEnumerable<Offer>> GetOffersByCustomer(string id);
        Task<CustomerDto> CreateOffer(string customerId, OfferRequestDto request);

        */

    }
}
