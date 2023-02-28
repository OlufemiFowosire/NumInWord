namespace NumInWord
{
    internal class Hundred : Wordable
    {
        private int hundVal;

        public Hundred()
        {
            priority = 4;
        }
        public override string convert()
        {
            return ConverterUtil.convertDigit(hundVal) + " hundred ";
        }

        public override bool IsMatch(int num)
        {
            hundVal = (num % 1000) / 100;
            return hundVal > 0;
        }

        public override bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 100 == 0 && num / 1000 != 0;
        }
    }
}
