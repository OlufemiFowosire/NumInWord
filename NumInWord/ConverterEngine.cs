namespace NumInWord
{
    internal class ConverterEngine
    {
        private readonly IComposer composable;
        private readonly List<Wordable> rules;

        public ConverterEngine(IEnumerable<Wordable> rules) {
            this.rules = new List<Wordable>();
            this.rules.AddRange(rules);
            composable = new Composer(this.rules);
        }

        public void addRule(Wordable w) { 
            rules.Add(w);
        }

        public void removeRule(Wordable w)
        {
            rules.Remove(w);
        }

        public string convert(long num)
        {
            return composable.convert(num);
        }
    }
}
