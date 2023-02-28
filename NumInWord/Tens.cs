using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Tens : IWordable
    {
        private int priority = 3;
        private int tensVal;

        public string convert(int num)
        {
            string result = string.Empty;
            if (InsertAnd(num))
            {
                result += "and ";
            }
            result += ConverterUtil.convertTens(tensVal / 10) + " ";

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
            tensVal = num % 100;
            return tensVal >= 20;
        }

        public bool InsertAnd(int num)
        {
            return IsMatch(num) && num > 100;
        }
    }
}
