namespace IfElseIfElse.CommandPattern.Operations
{

    internal class Addition : IOperation
    {
        public int GetResult(int number, int value)
        {
            return number + value;
        }

        public bool Supports(Operator @operator)
        {
            return @operator.Equals(Operator.Addition);
        }
    }

}
