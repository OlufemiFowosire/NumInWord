namespace NumInWord
{
    internal class TensUnit : Wordable
    {
        private long unitVal;

        public TensUnit() {
            priority = 2;
        }
        public override string convert()
        {
            return ConverterUtil.convertDigit(unitVal % 10) + " ";
        }

        public override bool IsMatch(long num)
        {
            unitVal = num % 100;
            return unitVal > 20;
        }

        public override bool InsertAnd(long num)
        {
            return false;
        }
    }
}
