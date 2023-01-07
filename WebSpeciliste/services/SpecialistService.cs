using Aggregates;
using Newtonsoft.Json.Linq;
using WebSpeciliste.Models;
using WebSpeciliste.services.SpecialistsService;

namespace WebSpeciliste.services
{
    public class SpecialistService : BaseService, ISpecialist
    {
        private readonly IHttpClientFactory _clientFactory;

        public SpecialistService(IHttpClientFactory httpClient) : base(httpClient)
        {
            _clientFactory = httpClient;
        }

        public async Task<T> CreateSpecialistAsync<T>(SpecialistDto specialist)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.POST,
                data = specialist,
                url = SD.host + "/api/specialits/create"
            });
        }

        public async Task<T> DeleteSpecialistAsync<T>(string id)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.DELETE,
                url = SD.host + "/api/specialits/" + id,
                //accessToken = accessToken
            });
        }



        public async Task<T> GetAllSpecialistsAsync<T>()
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.GET,
                url = SD.host + "/api/specialits/list",
                //accessToken = accessToken
            });
        }

        public async Task<T> GetOneSpecialistByIdAsync<T>(string id)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.GET,
                url = SD.host + "/api/specialits/" + id,
                //accessToken = accessToken
            });
        }

        public async Task<T> SeachSpecialistByNameAsync<T>(string name)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.GET,
                url = SD.host + "​/api​/specialits/list/" + name,
                //accessToken = accessToken
            });
        }

        
        public async Task<T> UpdateSpecialistAsync<T>(string id, SpecialistDto specialist)
        {
            return await this.SendDataAsync<T>(new ApiRequest()
            {
                method = SD.MethodType.PUT,
                data = specialist,
                url = SD.host + "/api/specialits/" + id,
                //accessToken = accessToken
            });
        }
    }
}
