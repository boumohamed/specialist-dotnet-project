using Aggregates;

using Newtonsoft.Json.Linq;
using WebSpeciliste.Models;
using WebSpeciliste.services.CustomerServices;

namespace WebSpeciliste.services
{
    public class Customerservice : BaseService, ICustomer
    {
        private readonly IHttpClientFactory _clientFactory;

        public Customerservice(IHttpClientFactory httpClient) : base(httpClient)
        {
            _clientFactory = httpClient;
        }

        public async Task<T> CreateOfferAsync<T>(OfferDto offer)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.POST,
                data = offer,
                url = SD.hostCustomer + "/customers/edab028107224aeda29e91341242aa59/offers/create"
            }, API.customerAPI);
        }

        public Task<T> GetAllCustomersAsync<T>()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetOneOfferAsync<T>(string id)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.GET,
                url = SD.hostCustomer + "/customers/offers/" + id,
                //accessToken = accessToken
            }, API.customerAPI);
        }

        public async Task<T> GetCustomerOffersAsync<T>(string id)
        {
            id = "edab028107224aeda29e91341242aa59";
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.GET,
                url = SD.hostCustomer + "/customers/" + id + "/offers",
                //accessToken = accessToken
            }, API.customerAPI);
        }

        public Task<T> GetOneCustomerByIdAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> RegisterAsync<T>(SpecialistDto specialist)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.POST,
                data = specialist,
                url = SD.hostSpecialist + "/api/specialits/create"
            }, API.SpecialistAPI);
        }

        public Task<T> SeachCustomerByNameAsync<T>(string name)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateOfferAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateProfileAsync<T>(string id, SpecialistDto specialist)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetOfferByLocationSpecialityKeywordAsync<T>(string speciality, string location, string keyword)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.GET,
                url = SD.hostCustomer + "/customers/offers/search?speciality=" + speciality + "&location=" + location + "&keyword=" + keyword
                //accessToken = accessToken
            }, API.customerAPI);
        }
        /*
public async Task<T> DeleteSpecialistAsync<T>(string id)
{
return await this.SendDataAsync<T>(new ApiRequest()
{
method = SD.MethodType.DELETE,
url = SD.host + "/api/specialits/" + id,
//accessToken = accessToken
}, API.SpecialistAPI);
}



public async Task<T> GetAllSpecialistsAsync<T>()
{
return await this.SendDataAsync<T>(new ApiRequest()
{
method = SD.MethodType.GET,
url = SD.host + "/api/specialits/list",
//accessToken = accessToken
}, API.SpecialistAPI);
}

public async Task<T> GetOneSpecialistByIdAsync<T>(string id)
{
return await this.SendDataAsync<T>(new ApiRequest()
{
method = SD.MethodType.GET,
url = SD.host + "/api/specialits/" + id,
//accessToken = accessToken
}, API.SpecialistAPI);
}

public async Task<T> SeachSpecialistByNameAsync<T>(string name)
{
return await this.SendDataAsync<T>(new ApiRequest()
{
method = SD.MethodType.GET,
url = SD.host + "​/api​/specialits/list/" + name,
//accessToken = accessToken
}, API.SpecialistAPI);
}


public async Task<T> UpdateSpecialistAsync<T>(string id, SpecialistDto specialist)
{
return await this.SendDataAsync<T>(new ApiRequest()
{
method = SD.MethodType.PUT,
data = specialist,
url = SD.host + "/api/specialits/" + id,
//accessToken = accessToken
}, API.SpecialistAPI);
}
*/
    }
}
