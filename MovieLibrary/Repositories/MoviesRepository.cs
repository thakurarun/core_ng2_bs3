using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLibrary.Models;
using MovieLibrary.ConnectionFactory;

namespace MovieLibrary.Repositories
{
    public interface IMoviesRepository
    {
        Task<IEnumerable<Movie>> MoviesList(string endPoint, Dictionary<string, string> queries);
    }
    public class MoviesRepository : BaseRepository, IMoviesRepository
    {
        IConnectionProvider connectionProvider;
        public MoviesRepository(IConnectionProvider _connectionProvider)
        {
            this.connectionProvider = _connectionProvider;
        }
        public async Task<IEnumerable<Movie>> MoviesList(string endPoint, Dictionary<string, string> queries)
        {
            var client = this.connectionProvider.GetClient();
            var response = await client.GetAsync(endPoint + queries?.GetQuery() ?? string.Empty);
            var moviesResult = ResolveResponse<MovieResultSet>(response);
            return moviesResult.Result.data.movies;
        }
    }
}
