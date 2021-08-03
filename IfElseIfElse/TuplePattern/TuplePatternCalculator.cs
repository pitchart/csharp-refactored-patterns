using System;

namespace IfElseIfElse.TuplePattern
{

    public class TuplePatternCalculator : ICalculator
    {
        public int Calculate(char operation, int number, int value)
        {
            return (operation, number, value) switch
            {
                ('+', _, _) => number + value,
                ('-', _, _) => number - value,
                ('*', _, _) => number * value,
                ('/', _, 0) => throw new InvalidOperationException(),
                ('/', _, _) => number / value,
                _ => throw new InvalidOperationException(),
            };
        }
    }

}
