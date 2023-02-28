namespace NumInWord
{
    internal class TensUnit : Wordable
    {
        private int unitVal;

        public TensUnit() {
            priority = 2;
        }
        public override string convert()
        {
            return ConverterUtil.convertDigit(unitVal % 10) + " ";
        }

        public override bool IsMatch(int num)
        {
            unitVal = num % 100;
            return unitVal > 20;
        }

        public override bool InsertAnd(int num)
        {
            return false;
        }
    }
}
