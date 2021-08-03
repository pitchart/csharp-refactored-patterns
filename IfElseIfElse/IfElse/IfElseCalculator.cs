using System;

namespace IfElseIfElse.IfElse
{

    public class IfElseCalculator : ICalculator
    {
        public int Calculate(char operation, int number, int value)
        {
            var op = operation.ToOperator();
            if (op == Operator.Addition)
                number += value;
            else if (op == Operator.Substraction)
                number -= value;
            else if (op == Operator.Multiplication)
                number *= value;
            else if (op == Operator.Division && value != 0)
                number /= value;
            else
                throw new InvalidOperationException();
            return number;
        }
    }

}
