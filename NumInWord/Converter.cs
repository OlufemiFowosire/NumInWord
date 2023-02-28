namespace NumInWord
{
    public sealed class Converter
    {
        private ConverterEngine engine;
        
        #nullable enable
        private static Converter? instance;
        public static Converter Instance {
            get
            {
                return instance ??= new Converter();
            }
        }

        #nullable disable
        private Converter() {
            var ruleType = typeof(Wordable);
            IEnumerable<Wordable> rules = this.GetType().Assembly.GetTypes()
                                                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsAbstract)
                                                .Select(p => Activator.CreateInstance(p) as Wordable)
                                                .OrderDescending();
            engine = new ConverterEngine(rules);
        }

        public string convertToWord(int num)
        {
            return engine.convert(num);
        }
    }
}
