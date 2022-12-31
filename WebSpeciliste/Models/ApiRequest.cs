using static WebSpeciliste.SD;

namespace WebSpeciliste.Models
{
    public class ApiRequest
    {
        public MethodType method { get; set; }
        public string url { get; set; }
        public object data { get; set; }
        public string accessToken { get; set; }
    }
}
