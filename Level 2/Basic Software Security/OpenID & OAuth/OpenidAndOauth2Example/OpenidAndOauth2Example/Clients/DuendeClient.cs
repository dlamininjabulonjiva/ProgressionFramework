using System.Net.Http;
using System.Threading.Tasks;

namespace OpenidAndOauth2Example.Clients
{
    public class DuendeClient : IDuendeClient
    {
        private readonly HttpClient _httpClient;

        public DuendeClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<HttpResponseMessage> GetTest()
        {
            return _httpClient.GetAsync("test");
        }
    }
}