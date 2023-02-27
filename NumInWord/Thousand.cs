using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Thousand : IWordable
    {
        private int priority = 4;

        public int getPriority() { 
            return priority; 
        }

        List<IWordable> baseRules = new List<IWordable>();

        public Thousand() {
            baseRules.Add(new Hundred());
            baseRules.Add(new Tens());
            baseRules.Add(new Unit());
        }
        public string convert(int num)
        {
            string result = string.Empty;

            int thousVal = (num % 1000000) / 1000;
            if (thousVal > 0)
            {
                foreach (var rule in baseRules)
                {
                    result += rule.convert(thousVal);
                }
                result += " thousand ";
            }
            
            return result;
        }

        public int CompareTo(IWordable? other)
        {
            return priority.CompareTo(other.getPriority());
        }
    }
}
