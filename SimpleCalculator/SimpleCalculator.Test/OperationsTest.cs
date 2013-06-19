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
    }
}