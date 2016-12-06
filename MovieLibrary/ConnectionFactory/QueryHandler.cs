using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.ConnectionFactory
{
    public static class QueryHandler
    {
        public static string GetQuery(this Dictionary<string, string> _params)
        {
            List<string> queries = new List<string>();
            foreach (var kv in _params)
                queries.Add(kv.Key + "=" + kv.Value);
            return "?" + String.Join("&", queries);
        }
    }
}
