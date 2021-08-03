using IfElseIfElse.IfElse;

namespace IfElseIfElse.Tests
{

    public class IfElseCalculatorTest : StringCalculatorTestCases
    {
        public IfElseCalculatorTest() : base(new StringCalculator(new IfElseCalculator()))
        {
        }
    }

}
