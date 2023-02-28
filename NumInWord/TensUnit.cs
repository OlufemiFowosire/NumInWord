using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class TensUnit : IWordable
    {
        private int priority = 2;
        private int unitVal;

        public int GetPriority() { 
            return priority; 
        }

        public string convert(int num)
        {
            string result = string.Empty;
            result += ConverterUtil.convertDigit(unitVal % 10);

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }

        public bool IsMatch(int num)
        {
            unitVal = num % 100;
            return unitVal > 20;
        }

        public bool InsertAnd(int num)
        {
            return false;
        }
    }
}
