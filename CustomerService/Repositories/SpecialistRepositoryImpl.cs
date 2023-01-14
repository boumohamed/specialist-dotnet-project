using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CustomerService.DbContexts;
using CustomerService.Models;
using CustomerService.Models.Dtos;


namespace CustomerService.Repositories
{
    public class CustomerRepositoryImpl : CustomerRepository
    {
        private readonly CustomerDBContext _db;
        private IMapper _mapper;

        public CustomerRepositoryImpl(CustomerDBContext db, IMapper mapper)
        {
                _db = db;
                _mapper = mapper;
        }

        public async Task<CustomerDto> CreateCustomer(CustomerRequestDto request)
        {
            if(request != null)
            {
                Guid UUID = Guid.NewGuid();
                Customer customer = _mapper.Map<Customer>(request);
                customer.customerId = UUID.ToString().Replace("-", "");
                _db.customers.Add(customer);
                await _db.SaveChangesAsync();
                Customer response = await _db.customers.Where(c => c.customerId == customer.customerId).FirstAsync();
                return _mapper.Map<CustomerDto>(response);
            }
            return null;
        }


        public async Task<ResponseDto> CreateOffer(string customerId, OfferRequestDto request)
        {
            ResponseDto response = new ResponseDto();
            Customer customer = await _db.customers.Where(c => c.customerId == customerId).FirstOrDefaultAsync();
            if(customer != null)
            {
                Offer offer = _mapper.Map<Offer>(request);
                Guid UUID = Guid.NewGuid();
                offer.offerId = UUID.ToString().Replace("-", "");
                offer.created = DateTime.Now;
                offer.customerId = customerId;
                customer.offers.Add(offer);
                await _db.SaveChangesAsync();
                response.result = _mapper.Map<List<OfferDto>>(offer);
                return response;
            }

            return response;

            
            
            
        }



        public async Task<ResponseDto> DeleteCustomer(string id)
        {
            ResponseDto res = new ResponseDto();
            Customer toDelete = await _db.customers.FirstOrDefaultAsync(c => c.customerId == id);
            if(toDelete != null)
            {
                _db.customers.Remove(toDelete);
                await _db.SaveChangesAsync();
            }
            else
            {
                res.success = false;
                res.DisplayMessage = "record not found";
                return res;
            }
            
            Customer delete = await _db.customers.Where(c => c.customerId == id).FirstOrDefaultAsync();
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

        public async Task<Customer> GetCustomerById(string id)
        {
            Customer response = await _db.customers.Where(c => c.customerId == id).FirstOrDefaultAsync();
            return response;
        }

        public async Task<IEnumerable<CustomerDto>> GetCustomers()
        {
            List<Customer> list = await _db.customers.ToListAsync();
            return _mapper.Map<List<CustomerDto>>(list);
        }

        public async Task<IEnumerable<Offer>> GetOffers(string id)
        {
            List<Offer> list = await _db.offers.ToListAsync();
            return _mapper.Map<List<Offer>>(list);
        }


        public async Task<IEnumerable<CustomerDto>> SearchCustomerByName(string name)
        {
            List<Customer> list = await _db.customers.Where(c => c.LastName.ToLower().Contains(name.ToLower())).ToListAsync();
            return _mapper.Map<List<CustomerDto>>(list);
        }

        public async Task<CustomerDto> UpdateCustomer(CustomerRequestDto request, string id)
        {
            if (request != null)
            {
                Customer customer = _mapper.Map<Customer>(request);
                customer.customerId = id;
                _db.customers.Update(customer);
                await _db.SaveChangesAsync();
                Customer response = await _db.customers.Where(c => c.customerId == customer.customerId).FirstAsync();
                return _mapper.Map<CustomerDto>(response);
            }
            return null;

        }

        public async Task<IEnumerable<OfferDto>> GetOffersByCustomer(string id)
        {
            List<Offer> list = await _db.offers.Where(o => o.customerId == id).ToListAsync();
            return _mapper.Map<List<OfferDto>>(list);
        }
    }
}
