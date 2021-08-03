namespace IfElseIfElse.ChainOfResponsibility.Operations
{

    internal class Addition : Operation
    {
        public override int GetResult(Operator @operator, int number, int value)
        {
            if (@operator.Equals(Operator.Addition)) return number + value;

            return this.Next().GetResult(@operator, number, value);
        }
    }

}
