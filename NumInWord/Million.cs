namespace NumInWord
{
    internal class Million : Wordable
    {
        private readonly IComposable composable;
        private int millVal;

        public Million()
        {
            priority= 6;
            composable = new Composable();
        }
        public override string convert()
        {
            return composable.convert(millVal) + "million ";
        }

        public override bool IsMatch(int num)
        {
            millVal = (num % 1000000000) / 1000000;
            return millVal > 0;
        }

        public override bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 1000000 == 0 && num / 1000000000 != 0 && millVal < 100;
        }
    }
}
