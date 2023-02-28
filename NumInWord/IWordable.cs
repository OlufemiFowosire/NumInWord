namespace NumInWord
{
    public interface IWordable : IComparable<IWordable>
    {
        string convert();

        short GetPriority();

        bool IsMatch(long num);

        bool InsertAnd(long num);
    }
}
