using System;

namespace IfElseIfElse.ChainOfResponsibility.Operations
{

    internal abstract class Operation : IOperation
    {
        private IOperation _next;

        public IOperation Next()
        {
            if (this._next is null) throw new InvalidOperationException();

            return this._next;
        }

        public IOperation SetNext(IOperation operation)
        {
            this._next = operation;
            return this;
        }

        public abstract int GetResult(Operator @operator, int number, int value);
    }

}
