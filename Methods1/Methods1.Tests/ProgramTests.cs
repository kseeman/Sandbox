using Xunit;

namespace CalcDemo.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            int result = Program.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int result = Program.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int result = Program.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int result = Program.Divide(6, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => Program.Divide(6, 0));
        }
    }
}