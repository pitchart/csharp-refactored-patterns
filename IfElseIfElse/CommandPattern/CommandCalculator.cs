using System;
using System.Collections.Generic;
using IfElseIfElse.CommandPattern.Operations;

namespace IfElseIfElse.CommandPattern
{

    public class CommandCalculator : ICalculator
    {
        private readonly IEnumerable<IOperation> _operations = new List<IOperation>
        {
            new Addition(), new Substraction(), new Multiplication(), new Division(),
        };

        public int Calculate(char @operator, int number, int value)
        {
            foreach (IOperation operation in this._operations)
                if (operation.Supports(@operator.ToOperator()))
                    return operation.GetResult(number, value);

            throw new InvalidOperationException();
        }
    }

}
