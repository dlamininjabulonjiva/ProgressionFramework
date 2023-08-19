using System.Net.Http;
using System.Threading.Tasks;

namespace OpenidAndOauth2Example.Clients
{
    public interface IDuendeClient
    {
        public Task<HttpResponseMessage> GetTest();
    }
}