using System;
using IfElseIfElse.CommandPattern;

namespace IfElseIfElse.PatternMatching
{

    internal class UnknownOperation : IOperation
    {
        public int GetResult(int number, int value)
        {
            throw new InvalidOperationException();
        }

        public bool Supports(Operator @operator)
        {
            return true;
        }
    }

}
