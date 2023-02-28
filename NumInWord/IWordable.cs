namespace NumInWord
{
    public interface IWordable : IComparable<IWordable>
    {
        string convert();

        int GetPriority();

        bool IsMatch(int num);

        bool InsertAnd(int num);
    }
}
