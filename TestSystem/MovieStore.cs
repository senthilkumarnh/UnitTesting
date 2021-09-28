using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class MovieStore : IMovieStore
    {
        private readonly Dictionary<string, int> movieReviewScores = new Dictionary<string, int>()
        {
            { "BadMovie", 5 },
            { "GoodMovie", 10 }
        };

        public double GetReviewScore(string title)
        {
            //Data base to get movie information.

            if (String.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title), "Movie title parameter is empty/null.");

            if (!movieReviewScores.ContainsKey(title))
                throw new ArgumentException(nameof(title), "Invalid movie name");

            return movieReviewScores[title];
        }
    }
}
