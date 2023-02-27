using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    public class Converter
    {
        ConverterEngine engine;
        public static Converter Instance {
            get { return new Converter(); }
        }
        private Converter() {
            var ruleType = typeof(IWordable);
            IEnumerable<IWordable?> rules = this.GetType().Assembly.GetTypes()
                                                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsAbstract)
                                                .Select(p => Activator.CreateInstance(p) as IWordable)
                                                .OrderByDescending(p => p);
            engine = new ConverterEngine(rules);
        }

        public string convertToWord(int num)
        {
            return engine.convert(num);
        }
    }
}
