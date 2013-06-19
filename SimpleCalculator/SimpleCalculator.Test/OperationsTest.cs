using Xunit;

namespace SimpleCalculator.Test
{
    public class OperationsTest
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void PlusOperation_ReturnsCorrectValue()
        {
            var result = calculator.Add(2, 2);
            
            Assert.Equal(4,result);
        }

        [Fact]
        public void MinusOperation_ReturnsCorrectValue()
        {
            var result = calculator.Substract(2, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void MultiplyOperation_ReturnsCorrectValue()
        {
            var result = calculator.Multiply(2, 2);

            Assert.Equal(4, result);
        }
    }
}