namespace IfElseIfElse.CommandPattern.Operations
{

    internal class Substraction : IOperation
    {
        public int GetResult(int number, int value)
        {
            return number - value;
        }

        public bool Supports(Operator @operator)
        {
            return @operator.Equals(Operator.Substraction);
        }
    }

}
