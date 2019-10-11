using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PetStore.Client
{
    public abstract class ClientBase
    {
        protected async Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
        {
            var msg = new HttpRequestMessage();
            await Task.CompletedTask;
            var token = "Get your token";
            msg.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return msg;
        }
    }
}
