using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieLibrary.ConnectionFactory
{
    public interface IConnectionProvider
    {
        HttpClient GetClient();
    }
    public class ConnectionProvider : IConnectionProvider
    {
        private HttpClient client;
        public ConnectionProvider(string baseUrl)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
        }

        public HttpClient GetClient()
        {
            return client;
        }
    }
}
