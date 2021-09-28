using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public interface IMovieSuggestion
    {
        MovieSuggestionResult GetMovieSuggestion(string title);
    }

    public class MovieSuggestionResult
    {
        public string MovieTitle { get; set; }
        public bool IsGoodMovie { get; set; }
    }
}
