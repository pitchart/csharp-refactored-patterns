using System;
using Xunit;

namespace IfElseIfElse.Tests
{

    public abstract class StringCalculatorTestCases
    {
        private readonly StringCalculator _calculator;

        public StringCalculatorTestCases(StringCalculator calculator)
        {
            this._calculator = calculator;
        }

        [Fact]
        public void Should_return_zero_when_string_is_empty()
        {
            Assert.Equal(0, this._calculator.Calculate(""));
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("15", 15)]
        public void Should_return_the_number_when_string_is_only_a_number(string operation, int result)
        {
            Assert.Equal(result, this._calculator.Calculate(operation));
        }

        [Theory]
        [InlineData("1+1", 2)]
        [InlineData("1-1", 0)]
        [InlineData("2*2", 4)]
        [InlineData("2/2", 1)]
        [InlineData("1+15-3*2", 26)]
        [InlineData("1+15-3*2-2/8", 3)]
        public void Should_calculate_simple_operation(string operation, int result)
        {
            Assert.Equal(result, this._calculator.Calculate(operation));
        }

        [Fact]
        public void Should_throw_exception_when_dividing_by_zero()
        {
            Exception exception = Record.Exception(() => this._calculator.Calculate("10/0"));

            Assert.NotNull(exception);
            Assert.IsType<InvalidOperationException>(exception);
        }

        [Fact]
        public void Should_throw_exception_when_operator_is_unknown()
        {
            Exception exception = Record.Exception(() => this._calculator.Calculate("10_0"));

            Assert.NotNull(exception);
            Assert.IsType<InvalidOperationException>(exception);
        }
    }

}
