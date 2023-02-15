namespace UnitTests.TDD
{
    public class CalculatorTests
    {
        [Fact]
        public void whenAddingOnePlusOneItShouldReturnTwo()
        {
            //Arrange
            var calculator = new Calculator();
            var firstVariable = 1;
            var secondVariable = 1;
            var expectedResult = 2;
            int actualresult;

            //Act
            actualresult = calculator.add(firstVariable, secondVariable);

            //Assert
            Assert.Equal(expectedResult, actualresult);
        }

        [Fact]
        public void whenAddingTwoPlusTwoItShouldReturnFour()
        {
            //Arrange
            var calculator = new Calculator();
            var firstVariable = 2;
            var secondVariable = 2;
            var expectedResult = 4;
            int actualresult;

            //Act
            actualresult = calculator.add(firstVariable, secondVariable);

            //Assert
            Assert.Equal(expectedResult, actualresult);
        }
    }
}