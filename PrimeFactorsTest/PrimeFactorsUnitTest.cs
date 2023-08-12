using PrimeFactorsLibrary;

namespace PrimeFactorsTest
{
    public class PrimeFactorsUnitTest
    {
        [Fact]
        public void PrimeFactorsOf25()
        {
            // Arrange
            var number = 25;
            var expected = "5 x 5";

            // Act
            PrimeFactorsCalculator.Calculate(number);
            var actual = PrimeFactorsCalculator.Result;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf977()
        {
            // Arrange
            var number = 977;
            var expected = "977";

            // Act
            PrimeFactorsCalculator.Calculate(number);
            var actual = PrimeFactorsCalculator.Result;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf420()
        {
            // Arrange
            var number = 420;
            var expected = "7 x 5 x 3 x 2 x 2";

            // Act
            PrimeFactorsCalculator.Calculate(number);
            var actual = PrimeFactorsCalculator.Result;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
