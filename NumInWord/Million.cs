using System;
using System.Collections.Generic;
using System.Text;

namespace NumInWord
{
    internal class Million : IWordable
    {
        private int priority = 5;

        public int getPriority()
        {
            return priority;
        }

        List<IWordable> baseRules = new List<IWordable>();

        public Million()
        {
            baseRules.Add(new Hundred());
            baseRules.Add(new Tens());
            baseRules.Add(new Unit());
        }
        public string convert(int num)
        {
            string result = string.Empty;

            int millVal = (num % 1000000000) / 1000000;
            if (millVal > 0)
            {
                foreach (var rule in baseRules)
                {
                    result += rule.convert(millVal);
                }
                result += " million ";
            }

            return result;
        }

        public int CompareTo(IWordable? other)
        {
            return priority.CompareTo(other.getPriority());
        }
    }
}
