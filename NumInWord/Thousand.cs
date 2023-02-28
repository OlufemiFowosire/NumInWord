using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Thousand : IWordable
    {
        private int priority = 5;
        private int thousVal;
        private List<IWordable> baseRules;

        public Thousand() {
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

            if (InsertAnd(num))
            {
                result += "and ";
            }
            foreach (var rule in baseRules)
            {
                if (rule.IsMatch(thousVal))
                {
                    result += rule.convert(thousVal);
                }
            }
            result += " thousand ";

            return result;
        }

        public int GetPriority()
        {
            return priority;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }

        public bool IsMatch(int num)
        {
            thousVal = (num % 1000000) / 1000;
            return thousVal > 0;
        }

        public bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 1000 == 0 && num / 1000000 != 0 && thousVal < 100;
        }
    }
}
