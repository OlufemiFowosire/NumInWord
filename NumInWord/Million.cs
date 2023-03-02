namespace NumInWord
{
    internal class Million : Wordable
    {
        private readonly IComposer composable;
        private long millVal;

        public Million()
        {
            priority= 6;
            composable = new Composer();
        }
        public override string convert()
        {
            return composable.convert(millVal) + "million ";
        }

        public override bool IsMatch(long num)
        {
            millVal = (num % 1000000000) / 1000000;
            return millVal > 0;
        }

        public override bool InsertAnd(long num)
        {
            return IsMatch(num) && num % 1000000 == 0 && num / 1000000000 != 0 && millVal < 100;
        }
    }
}
