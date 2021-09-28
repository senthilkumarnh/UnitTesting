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
    public class MovieSuggestionTests
    {
        [Fact]
        public void GetMovieSuggestion_GoodMovieName_ReturnsTrue()
        {
            //Arrange
            IMovieSuggestion movieSuggestion = new MovieSuggestion();
            var title = "GoodMovie";

            //Act
            var movieReview = movieSuggestion.GetMovieSuggestion(title);

            //Assert
            Assert.True(movieReview.IsGoodMovie);
        }

        [Fact]
        public void GetMovieSuggestion_GoodMovieName_ReturnsFalse()
        {
            //Arrange
            IMovieStore movieStoreFake = A.Fake<IMovieStore>();
            A.CallTo(() => movieStoreFake.GetReviewScore(A<string>.Ignored)).Returns(8);

            IMovieSuggestion movieSuggestion = new MovieSuggestion(movieStoreFake);
            var title = "GoodMovie";

            //Act
            var movieReview = movieSuggestion.GetMovieSuggestion(title);

            //Assert
            //Check IsGoodMovie is true
            Assert.True(movieReview.IsGoodMovie);

            //Check movie name matches with input param
            Assert.Equal(title, movieReview.MovieTitle);

            ////Arrange
            //IMovieSuggestion movieStore = new MovieSuggestion();
            //var title = "GoodMovie";

            ////Act
            //var movieReview = movieStore.GetMovieSuggestion(title);

            ////Assert
            //movieReview.MovieTitle.Should().Be(title);
            //movieReview.IsGoodMovie.Should().Be(false);
        }
    }
}
