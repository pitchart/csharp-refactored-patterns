namespace IfElseIfElse
{

    internal static class OperatorAdapter
    {
        public static Operator ToOperator(this char @operator)
        {
            return @operator switch
            {
                '+' => Operator.Addition,
                '-' => Operator.Substraction,
                '*' => Operator.Multiplication,
                '/' => Operator.Division,
                _ => Operator.Unknown,
            };
        }
    }

}
