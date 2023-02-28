using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class ConverterEngine
    {
        List<IWordable> rules= new List<IWordable>();

        public ConverterEngine(IEnumerable<IWordable> rules) {
            this.rules.AddRange(rules);
        }

        public void addRule(IWordable w) { 
            rules.Add(w);
        }

        public void removeRule(IWordable w)
        {
            rules.Remove(w);
        }

        public string convert(int num)
        {
            string result = string.Empty;
            foreach (var rule in rules)
            {
                result += rule.convert(num);
            }
            return result;
        }
    }
}
