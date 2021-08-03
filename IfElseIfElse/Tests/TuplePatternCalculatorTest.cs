using IfElseIfElse.TuplePattern;

namespace IfElseIfElse.Tests
{

    public class TuplePatternCalculatorTest : StringCalculatorTestCases
    {
        public TuplePatternCalculatorTest() : base(new StringCalculator(new TuplePatternCalculator()))
        {
        }
    }

}
