using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieLibrary.ConnectionFactory;
using MovieLibrary.Repositories;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace POC_CORE_Angular2.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<object> Get()
        {
            IConnectionProvider provider = new ConnectionProvider("https://yts.ag/api/v2/");
            IMoviesRepository movieRepository = new MoviesRepository(provider);
            var movies = movieRepository.MoviesList("list_movies.json", new Dictionary<string, string> { }).Result;
            return movies;
        }
    }
}
