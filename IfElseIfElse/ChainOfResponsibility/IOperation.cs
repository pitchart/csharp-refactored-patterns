namespace IfElseIfElse.ChainOfResponsibility
{

    internal interface IOperation
    {
        IOperation Next();

        IOperation SetNext(IOperation operation);

        int GetResult(Operator @operator, int number, int value);
    }

}
