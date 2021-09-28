using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class MovieSuggestion : IMovieSuggestion
    {
        private readonly IMovieStore score = null;

        public MovieSuggestion()
        {
            score = new MovieStore();
        }

        public MovieSuggestion(IMovieStore movieScore)
        {
            score = movieScore;
        }

        public MovieSuggestionResult GetMovieSuggestion(string title)
        {
            //get movie score 
            var currentMovieScore = score.GetReviewScore(title);

            return new MovieSuggestionResult() { MovieTitle = title, IsGoodMovie = currentMovieScore > 5 };
        }
    }
}
