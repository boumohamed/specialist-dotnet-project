using WebSpeciliste.Models;

namespace WebSpeciliste.services.SpecialistsService
{
    public interface IBaseService : IDisposable
    {
        public ResponseDto responseModel { get; set; }
        Task<T> SendDataAsync<T>(ApiRequest request);
    }
}
