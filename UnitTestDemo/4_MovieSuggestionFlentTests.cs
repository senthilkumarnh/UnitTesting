using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem;
using Xunit;
using FluentAssertions;
using FakeItEasy;

namespace UnitTestDemo
{
    public class MovieSuggestionFluentTests
    {
        private object m_moduleProcessingLock = new object();

        [Fact]
        public async Task GetMovieSuggestion_GoodMovieName_ReturnsFalse()
        {

            //Arrange
            IMovieStore movieStoreFake = A.Fake<IMovieStore>();
            A.CallTo(() => movieStoreFake.GetReviewScore(A<string>.Ignored)).Returns(8);

            IMovieSuggestion movieSuggestion = new MovieSuggestion(movieStoreFake);
            var title = "GoodMovie";

            //Act
            var movieReview = movieSuggestion.GetMovieSuggestion(title);

            //Assert
            movieReview.MovieTitle.Should().Be(title);
            movieReview.IsGoodMovie.Should().Be(true);

        }

        
    }
}
