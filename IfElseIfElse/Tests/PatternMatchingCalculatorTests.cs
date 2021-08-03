using IfElseIfElse.PatternMatching;

namespace IfElseIfElse.Tests
{

    public class PatternMatchingCalculatorTests : StringCalculatorTestCases
    {
        public PatternMatchingCalculatorTests() : base(new StringCalculator(new PatternMatchingCalculator()))
        {
        }
    }

}
