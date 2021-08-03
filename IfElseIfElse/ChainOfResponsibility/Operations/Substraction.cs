namespace IfElseIfElse.ChainOfResponsibility.Operations
{

    internal class Substraction : Operation
    {
        public override int GetResult(Operator @operator, int number, int value)
        {
            if (@operator.Equals(Operator.Substraction)) return number - value;

            return this.Next().GetResult(@operator, number, value);
        }
    }

}
