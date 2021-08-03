namespace IfElseIfElse.CommandPattern
{

    public interface IOperation
    {
        int GetResult(int number, int value);

        bool Supports(Operator @operator);
    }

}
