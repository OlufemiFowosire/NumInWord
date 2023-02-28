namespace NumInWord
{
    internal abstract class Wordable : IWordable
    {
        protected short priority;
        
        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }
        public abstract string convert();
        public short GetPriority()
        {
            return priority;
        }
        public abstract bool InsertAnd(long num);
        public abstract bool IsMatch(long num);

        public string convert(long num)
        {
            string result = string.Empty;
            if (InsertAnd(num))
            {
                result += "and ";
            }
            result += convert();

            return result;
        }
    }
}
