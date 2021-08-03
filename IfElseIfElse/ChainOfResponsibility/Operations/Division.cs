namespace IfElseIfElse.ChainOfResponsibility.Operations
{

    internal class Division : Operation
    {
        public override int GetResult(Operator @operator, int number, int value)
        {
            if (@operator.Equals(Operator.Division) && value != 0) return number / value;

            return this.Next().GetResult(@operator, number, value);
        }
    }

}
