namespace NumInWord
{
    internal class Hundred : Wordable
    {
        private long hundVal;

        public Hundred()
        {
            priority = 4;
        }
        public override string convert()
        {
            return ConverterUtil.convertDigit(hundVal) + " hundred ";
        }

        public override bool IsMatch(long num)
        {
            hundVal = (num % 1000) / 100;
            return hundVal > 0;
        }

        public override bool InsertAnd(long num)
        {
            return IsMatch(num) && num % 100 == 0 && num / 1000 != 0;
        }
    }
}
