using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Hundred : IWordable
    {
        private int priority = 3;

        public int getPriority() { 
            return priority; 
        }
        public string convert(int num)
        {
            string result = string.Empty;
            int hundVal = (num % 1000) / 100;
            if (hundVal > 0)
            {
                result += ConverterUtil.convertDigit(hundVal) + " hundred ";
            }

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.getPriority());
        }
    }
}
