using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Tens : IWordable
    {
        private int priority = 2;

        public int getPriority() { 
            return priority; 
        }

        public string convert(int num)
        {
            string result = string.Empty;
            int tensVal = num % 100;
            if (tensVal >= 20 && tensVal < 100 && num > 100)
            {
                result += "and ";
            }
            if (tensVal >= 20)
            {
                result += ConverterUtil.convertTens(tensVal / 10) + " ";
            }

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.getPriority());
        }
    }
}
