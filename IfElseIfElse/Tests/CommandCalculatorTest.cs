using IfElseIfElse.CommandPattern;

namespace IfElseIfElse.Tests
{

    public class CommandCalculatorTest : StringCalculatorTestCases
    {
        public CommandCalculatorTest() : base(new StringCalculator(new CommandCalculator()))
        {
        }
    }

}
