using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Thousand : Wordable
    {
        private int thousVal;
        private readonly List<Wordable> baseRules;

        public Thousand() {
            priority = 5;
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
                if (rule.IsMatch(thousVal))
                {
                    result += rule.convert(thousVal);
                }
            }
            result += "thousand ";

            return result;
        }

        public override bool IsMatch(int num)
        {
            thousVal = (num % 1000000) / 1000;
            return thousVal > 0;
        }

        public override bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 1000 == 0 && num / 1000000 != 0 && thousVal < 100;
        }
    }
}
