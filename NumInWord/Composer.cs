namespace NumInWord
{
    internal class Composer : IComposer
    {
        List<Wordable> baseRules;

        public Composer()
        {
            baseRules = new List<Wordable>()
            {
                new Hundred(),
                new Tens(),
                new TensUnit(),
                new Unit()
            };
        }
        public Composer(List<Wordable> rules)
        {
            baseRules = rules;
        }
        public string convert(long value)
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
