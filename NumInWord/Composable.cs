namespace NumInWord
{
    internal class Composable : IComposable
    {
        List<Wordable> baseRules;

        public Composable()
        {
            baseRules = new List<Wordable>()
            {
                new Hundred(),
                new Tens(),
                new TensUnit(),
                new Unit()
            };
        }
        public Composable(List<Wordable> rules)
        {
            baseRules = rules;
        }
        public string convert(int value)
        {
            string result = string.Empty;
            foreach (var rule in baseRules)
            {
                if (rule.IsMatch(value))
                {
                    result += rule.convert(value);
                }
            }

            return result;
        }
    }
}
