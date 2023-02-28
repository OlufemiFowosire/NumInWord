namespace NumInWord
{
    internal class Tens : Wordable
    {
        private int tensVal;

        public Tens()
        {
            priority = 3;
        }

        public override string convert()
        {
            return ConverterUtil.convertTens(tensVal / 10) + " ";
        }

        public override bool IsMatch(int num)
        {
            tensVal = num % 100;
            return tensVal >= 20;
        }

        public override bool InsertAnd(int num)
        {
            return IsMatch(num) && num > 100;
        }
    }
}
