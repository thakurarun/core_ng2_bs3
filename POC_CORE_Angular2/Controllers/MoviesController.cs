using Microsoft.AspNetCore.Mvc;
using MovieLibrary.ConnectionFactory;
using MovieLibrary.Repositories;
using CommonLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MovieLibrary.Models;
using POC_CORE_Angular2.WebModel.DTO;
using POC_CORE_Angular2.WebModel;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace POC_CORE_Angular2.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private IConnectionProvider provider;
        private IMoviesRepository movieRepository;
        //public MoviesController(IConnectionProvider provider, IMoviesRepository movieRepository)
        public MoviesController()
        {
            //this.provider = provider;
            //this.movieRepository = movieRepository;

            this.provider = new ConnectionProvider("https://yts.ag/api/v2/");
            this.movieRepository = new MoviesRepository(provider);
        }

        // GET: api/values
        [HttpGet]
        public async Task<MovieSearchResult> Get()
        {
            var query = new Dictionary<string, string>();
            query.Add(QueryFilters.ListMovies_Limit, "5");
            query.Add(QueryFilters.ListMovies_Page, "1");
            var responseMovies = await movieRepository.MoviesList(Endpoints.ListMovies, query);
            var movies = Mapper.Map<IEnumerable<Movie>, IEnumerable<MovieDTO>>(responseMovies);

            return new MovieSearchResult
            {
                IsSuccess = true,
                movies = movies,
                PreserveData = query
            };
        }

        [HttpGet("next/{page}")]
        public async Task<MovieSearchResult> Get(string page)
        {
            var query = new Dictionary<string, string>();
            query.Add(QueryFilters.ListMovies_Limit, "5");
            query.Add(QueryFilters.ListMovies_Page, page);
            var responseMovies = await movieRepository.MoviesList(Endpoints.ListMovies, query);
            var movies = Mapper.Map<IEnumerable<Movie>, IEnumerable<MovieDTO>>(responseMovies);

            return new MovieSearchResult
            {
                IsSuccess = true,
                movies = movies,
                PreserveData = query
            };
        }


    }
}
