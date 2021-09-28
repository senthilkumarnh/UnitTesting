using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem;
using Xunit;

namespace UnitTestDemo
{
    public class MovieStoreDataDrivenTests
    {
        /// <summary>
        /// Use Theory when you want to write test case with different parameter values
        /// </summary>
        /// <param name="movieTitle"></param>
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void GetReviewScore_MovieNameDataTypeDefaultValues_ArgumentNullException(string movieTitle)
        {
            //Arrange
            IMovieStore movieStore = new MovieStore();

            //Act
            Action act = () => movieStore.GetReviewScore(movieTitle);

            //Assert
            Assert.Throws<ArgumentNullException>(act);
        }
    }
}
