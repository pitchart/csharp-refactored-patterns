using IfElseIfElse.SwitchCase;

namespace IfElseIfElse.Tests
{

    public class SwitchCaseCalculatorTest : StringCalculatorTestCases
    {
        public SwitchCaseCalculatorTest() : base(new StringCalculator(new SwitchCaseCalculator()))
        {
        }
    }

}
