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

        public int getPriority() { 
            return priority; 
        }

        public string convert(int num)
        {
            string result = string.Empty;
            int unitVal = num % 100;
            if (unitVal > 0 && unitVal < 20 && num > 100)
            {
                result += "and ";
            }
            if(unitVal > 20)
            {
                result += ConverterUtil.convertDigit(unitVal % 10);
            }
            else if (unitVal < 20)
            {
                result += ConverterUtil.convertDigit(unitVal);
            }

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.getPriority());
        }
    }
}
