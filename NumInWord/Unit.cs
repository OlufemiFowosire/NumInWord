using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Unit : Wordable
    {
        private int unitVal;

        public Unit() {
            priority = 1;
        }

        public override string cconvert()
        {
            return ConverterUtil.convertDigit(unitVal) + " ";
        }

        public override bool IsMatch(int num)
        {
            unitVal = num % 100;
            return unitVal > 0 && unitVal < 20;
        }

        public override bool InsertAnd(int num)
        {
            return IsMatch(num) && num > 100;
        }
    }
}
