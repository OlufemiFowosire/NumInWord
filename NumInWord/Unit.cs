using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Unit : IWordable
    {
        private int priority = 1;
        private int unitVal;

        public int GetPriority() { 
            return priority; 
        }

        public string convert(int num)
        {
            string result = string.Empty;
            if (InsertAnd(num))
            {
                result += "and ";
            }
            result += ConverterUtil.convertDigit(unitVal);

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }

        public bool IsMatch(int num)
        {
            unitVal = num % 100;
            return unitVal > 0 && unitVal < 20;
        }

        public bool InsertAnd(int num)
        {
            return IsMatch(num) && num > 100;
        }
    }
}
