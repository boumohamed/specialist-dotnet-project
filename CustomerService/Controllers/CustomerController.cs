using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerService.Models;
using CustomerService.Models.Dtos;
using CustomerService.Repositories;
using System.Collections;

namespace CustomerService.Controllers
{
    [Route("customers/")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerRepository _customerRepository;
        private ResponseDto _response;


        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _response = new ResponseDto();
        }
        [HttpGet]
        [Route("list")]
        public async Task<ResponseDto> GetCustomersList()
        {
            IEnumerable<CustomerDto> res = await _customerRepository.GetCustomers();
            _response.success = true;
            _response.result = res;
            return _response;
        }
        [HttpGet]
        [Route("list/{name}")]
        public async Task<object> GetByName([FromRoute] string name)
        {
            IEnumerable<CustomerDto> res = await _customerRepository.SearchCustomerByName(name);
            return res;
        }

        [HttpGet]
        [Route("list/{id}")]
        public async Task<ResponseDto> getCustomerById([FromRoute] string id)
        {

            Customer res = await _customerRepository.GetCustomerById(id);
            _response.success = true;
            _response.result = res;
            return _response;

        }

        [HttpPost]
        [Route("create")]
        public async Task<ResponseDto> Add(CustomerRequestDto requestDto)
        {

                CustomerDto res =  await _customerRepository.CreateCustomer(requestDto);
                _response.result = res;
                _response.success = true;
                return _response;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ResponseDto> deleteById([FromRoute] string id)
        {

            return await _customerRepository.DeleteCustomer(id); ;

        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ResponseDto> update(CustomerRequestDto requestDto, [FromRoute] string id)
        {

            CustomerDto res = await _customerRepository.UpdateCustomer(requestDto, id);
            if (res == null)
            {
                _response.result = null;
                _response.success = false;
                _response.DisplayMessage = "recorrd Not Found";
            }
            else
            {
                _response.result = res;
                _response.success = true;
            }

            return _response;

        }


        [HttpPost]
        [Route("{customerId}/offers/create")]
        public async Task<ResponseDto> AddOffer([FromRoute] string customerId, OfferRequestDto request)
        {
            //CreateOffer
            ResponseDto res = await _customerRepository.CreateOffer(customerId, request);
            _response.result = res;
            _response.success = true;
            return _response;
        }

        [HttpGet]
        [Route("{customerId}/offers")]
        public async Task<ResponseDto> getOffersByCustomer([FromRoute] string customerId)
        {
            //CreateOffer
            IEnumerable<OfferDto> res = await _customerRepository.GetOffersByCustomer(customerId);
            _response.result = res;
            _response.success = true;
            return _response;
        }

        

        [HttpGet]
        [Route("offers")]
        public async Task<ResponseDto> getAllOffers()
        {

            IEnumerable<OfferDto> res = await _customerRepository.GetOffers();
            _response.result = res;
            
            if(res == null)
            {
                _response.success = false;
                _response.errorMessages.Add("Record not found");
                _response.DisplayMessage = "Record not found";
                return _response;
            }

            return _response;

        }

        [HttpGet]
        [Route("offers/search")]
        public async Task<ResponseDto> getAllOffers(string? speciality, string? location, string? keyword)
        {
            
            IEnumerable<OfferDto> res = await _customerRepository.GetOffersBySpecialityLocationKeyword(speciality, location, keyword);
            _response.result = res;

            if (res == null)
            {
                _response.success = false;
                _response.errorMessages.Add("Record not found");
                _response.DisplayMessage = "Record not found";
                return _response;
            }

            return _response;

        }

        [HttpGet]
        [Route("offers/{id}")]
        public async Task<ResponseDto> getOffer(string id)
        {

            OfferDto res = await _customerRepository.GetOffer(id);
            _response.result = res;

            if (res == null)
            {
                _response.success = false;
                _response.errorMessages.Add("Record not found");
                _response.DisplayMessage = "Record not found";
                return _response;
            }

            return _response;

        }




    }

}
