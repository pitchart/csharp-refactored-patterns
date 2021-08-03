using System;

namespace IfElseIfElse.CommandPattern.Operations
{

    internal class Division : IOperation
    {
        public int GetResult(int number, int value)
        {
            if (value == 0) throw new InvalidOperationException();
            return number / value;
        }

        public bool Supports(Operator @operator)
        {
            return @operator.Equals(Operator.Division);
        }
    }

}
