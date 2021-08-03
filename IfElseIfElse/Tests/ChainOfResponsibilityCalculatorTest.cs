using IfElseIfElse.ChainOfResponsibility;

namespace IfElseIfElse.Tests
{

    public class ChainOfResponsibilityCalculatorTest : StringCalculatorTestCases
    {
        public ChainOfResponsibilityCalculatorTest() : base(new StringCalculator(new ChainOfResponsibilityCalculator()))
        {
        }
    }

}
