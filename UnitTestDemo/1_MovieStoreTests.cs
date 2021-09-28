using System;
using TestSystem;
using Xunit;

namespace UnitTestDemo
{
    public class MovieStoreTests
    {
        [Fact]
        public void GetReviewScore_NullMovieName_ArgumentNullException()
        {
            //Arrange
            IMovieStore movieStore = new MovieStore();

            //Act
            Action act = () => movieStore.GetReviewScore(null);

            //Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void GetReviewScore_EmptyMovieName_ArgumentNullException()
        {
            //Arrange
            IMovieStore movieStore = new MovieStore();

            //Act
            Action act = () => movieStore.GetReviewScore("");

            //Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void GetReviewScore_EmptySpaceMovieName_ArgumentNullException()
        {
            //Arrange
            IMovieStore movieStore = new MovieStore();

            //Act
            Action act = () => movieStore.GetReviewScore("   ");

            //Assert
            Assert.Throws<ArgumentNullException>(act);
        }
    }
}
