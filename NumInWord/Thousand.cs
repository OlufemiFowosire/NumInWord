namespace NumInWord
{
    internal class Thousand : Wordable
    {
        private readonly IComposer composable;
        private long thousVal;

        public Thousand() {
            priority = 5;
            composable = new Composer();
        }
        public override string convert()
        {
            return composable.convert(thousVal) + "thousand ";
        }

        public override bool IsMatch(long num)
        {
            thousVal = (num % 1000000) / 1000;
            return thousVal > 0;
        }

        public override bool InsertAnd(long num)
        {
            return IsMatch(num) && num % 1000 == 0 && num / 1000000 != 0 && thousVal < 100;
        }
    }
}
