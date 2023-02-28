namespace NumInWord
{
    internal class Tens : Wordable
    {
        private long tensVal;

        public Tens()
        {
            priority = 3;
        }

        public override string convert()
        {
            return ConverterUtil.convertTens(tensVal / 10) + " ";
        }

        public override bool IsMatch(long num)
        {
            tensVal = num % 100;
            return tensVal >= 20;
        }

        public override bool InsertAnd(long num)
        {
            return IsMatch(num) && num > 100;
        }
    }
}
