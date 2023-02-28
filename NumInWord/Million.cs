using System;
using System.Collections.Generic;
using System.Text;

namespace NumInWord
{
    internal class Million : IWordable
    {
        private int priority = 6;
        private int millVal;

        public int GetPriority()
        {
            return priority;
        }

        List<IWordable> baseRules;

        public Million()
        {
            baseRules = new List<IWordable>
            {
                new Hundred(),
                new Tens(),
                new TensUnit(),
                new Unit()
            };
        }
        public string convert(int num)
        {
            string result = string.Empty;
            foreach (var rule in baseRules)
            {
                if (rule.IsMatch(millVal))
                {
                    result += rule.convert(millVal);
                }
            }
            result += " million ";

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }

        public bool IsMatch(int num)
        {
            millVal = (num % 1000000000) / 1000000;
            return millVal > 0;
        }

        public bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 1000000 == 0 && num / 1000000000 != 0 && millVal < 100;
        }
    }
}
