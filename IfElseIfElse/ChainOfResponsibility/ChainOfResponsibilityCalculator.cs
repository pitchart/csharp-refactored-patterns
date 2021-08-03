using IfElseIfElse.ChainOfResponsibility.Operations;

namespace IfElseIfElse.ChainOfResponsibility
{

    public class ChainOfResponsibilityCalculator : ICalculator
    {
        private readonly IOperation _operations;

        public ChainOfResponsibilityCalculator()
        {
            this._operations = new Addition().SetNext(
                new Substraction().SetNext(new Multiplication().SetNext(new Division())));
        }

        public int Calculate(char operation, int number, int value)
        {
            return this._operations.GetResult(operation.ToOperator(), number, value);
        }
    }

}
