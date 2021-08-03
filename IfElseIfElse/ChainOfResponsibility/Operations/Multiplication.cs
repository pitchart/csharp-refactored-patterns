namespace IfElseIfElse.ChainOfResponsibility.Operations
{

    internal class Multiplication : Operation
    {
        public override int GetResult(Operator @operator, int number, int value)
        {
            if (@operator.Equals(Operator.Multiplication)) return number * value;

            return this.Next().GetResult(@operator, number, value);
        }
    }

}
