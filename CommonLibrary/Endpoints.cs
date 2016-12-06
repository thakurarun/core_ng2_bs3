namespace CommonLibrary
{
    public class Endpoints
    {
        public const string ListMovies = "list_movies.json";
        public const string MovieDetail = "movie_details.json";
        public const string MovieSuggestions = "movie_suggestions.json";
        public const string MovieComments = "movie_comments.json";
        public const string MovieReviews = "movie_reviews.json";
    }

    /// <summary>
    /// https://yts.ag/api#list_movies
    /// </summary>
    public class QueryFilters
    {

        #region List movies filters

        /// <summary>
        /// Integer between 1 - 50 (inclusive)
        /// </summary>
        public const string ListMovies_Limit = "limit";
        public const string ListMovies_Page = "page";
        /// <summary>
        /// String (720p, 1080p, 3D)
        /// </summary>
        public const string ListMovies_Quality = "quality";
        /// <summary>
        /// Integer between 0 - 9 (inclusive)
        /// </summary>
        public const string ListMovies_MinimumRating = "minimum_rating";
        /// <summary>
        /// Used for movie search, matching on: Movie Title/IMDb Code, Actor Name/IMDb Code, Director Name/IMDb Code
        /// </summary>
        public const string ListMovies_QueryTerm = "query_term";
        public const string ListMovies_Genere = "genre";
        /// <summary>
        /// String (title, year, rating, peers, seeds, download_count, like_count, date_added)
        /// </summary>
        public const string ListMovies_SortBy = "sort_by";
        /// <summary>
        /// String(desc, asc)
        /// </summary>
        public const string ListMovies_OrderBy = "order_by";
        /// <summary>
        /// boolean
        /// </summary>
        public const string ListMovies_WithRottenRatings = "with_rt_ratings";

        #endregion

        #region Movie detail filters
        /// <summary>
        /// The ID of the movie
        /// </summary>
        public const string MovieDetail_MovieReviews = "movie_id";
        /// <summary>
        /// When set the data returned will include the added image URLs
        /// true or false
        /// </summary>
        public const string MovieDetail_WithImages = "with_images";
        /// <summary>
        /// When set the data returned will include the added information about the cast
        /// true or false
        /// </summary>
        public const string MovieDetail_WithCast = "with_cast";
        #endregion

        #region Movie Suggestions
        /// <summary>
        /// The ID of the movie
        /// </summary>
        public const string MovieSuggestions_MovieId = "movie_id";
        #endregion

        #region Movie Comments
        /// <summary>
        /// The ID of the movie
        /// </summary>
        public const string MovieComments_MovieId = "movie_id";
        #endregion
    }

}
