using System;
using System.Collections.Generic;
using IfElseIfElse.CommandPattern;
using IfElseIfElse.CommandPattern.Operations;

namespace IfElseIfElse.PatternMatching
{

    public class PatternMatchingCalculator : ICalculator
    {
        private readonly IDictionary<Operator, IOperation> _operations = new Dictionary<Operator, IOperation>
        {
            { Operator.Addition, new Addition() },
            { Operator.Substraction, new Substraction() },
            { Operator.Multiplication, new Multiplication() },
            { Operator.Division, new Division() },
            { Operator.Unknown, new UnknownOperation() },
        };

        public int Calculate(char operation, int number, int value)
        {
            this._operations.TryGetValue(operation.ToOperator(), out IOperation op);
            return op switch
            {
                Division division when value == 0 => throw new InvalidOperationException(),
                null => throw new InvalidOperationException(),
                _ => op.GetResult(number, value),
            };
        }
    }

}
