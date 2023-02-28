using System;
using System.Collections.Generic;
using System.Text;

namespace NumInWord
{
    internal class Million : Wordable
    {
        private int millVal;

        private readonly List<Wordable> baseRules;

        public Million()
        {
            priority= 6;
            baseRules = new List<Wordable>
            {
                new Hundred(),
                new Tens(),
                new TensUnit(),
                new Unit()
            };
        }
        public override string cconvert()
        {
            string result = string.Empty;
            foreach (var rule in baseRules)
            {
                if (rule.IsMatch(millVal))
                {
                    result += rule.convert(millVal);
                }
            }
            result += "million ";

            return result;
        }

        public override bool IsMatch(int num)
        {
            millVal = (num % 1000000000) / 1000000;
            return millVal > 0;
        }

        public override bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 1000000 == 0 && num / 1000000000 != 0 && millVal < 100;
        }
    }
}
