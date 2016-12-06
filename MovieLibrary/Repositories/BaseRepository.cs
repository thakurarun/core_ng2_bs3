using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace MovieLibrary.Repositories
{
    public abstract class BaseRepository
    {
        public async Task<T> ResolveResponse<T>(HttpResponseMessage response) where T : class
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseString);
            }
            else
            {
                // TODO: log if query is invalid..
                return default(T);
            }
        }
    }
}
