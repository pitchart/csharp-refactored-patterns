using System;

namespace IfElseIfElse.SwitchCase
{

    public class SwitchCaseCalculator : ICalculator
    {
        public int Calculate(char operation, int number, int value)
        {
            return operation.ToOperator() switch
            {
                Operator.Addition => number + value,
                Operator.Substraction => number - value,
                Operator.Multiplication => number * value,
                Operator.Division when value == 0 => throw new InvalidOperationException(),
                Operator.Division => number / value,
                _ => throw new InvalidOperationException(),
            };
        }
    }

}
