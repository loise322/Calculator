using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibTests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void Calculate_2Add2_Return4()
        {
            //Arrange
            SimpleCalculator calculator = new SimpleCalculator();
            //Act
            int result = calculator.Calculate("2 + 2");

            //Assert
            Assert.Equal(4, result);
        }
    }
}
