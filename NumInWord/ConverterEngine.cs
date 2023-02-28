using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class ConverterEngine
    {
        private readonly List<Wordable> rules;

        public ConverterEngine(IEnumerable<Wordable> rules) {
            this.rules = new List<Wordable>();
            this.rules.AddRange(rules);
        }

        public void addRule(Wordable w) { 
            rules.Add(w);
        }

        public void removeRule(Wordable w)
        {
            rules.Remove(w);
        }

        public string convert(int num)
        {
            string result = string.Empty;
            foreach (var rule in rules)
            {
                if (rule.IsMatch(num))
                {
                    result += rule.convert(num);
                }
            }
            return result;
        }
    }
}
