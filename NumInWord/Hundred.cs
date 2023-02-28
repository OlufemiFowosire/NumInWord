﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Hundred : IWordable
    {
        private int priority = 4;
        private int hundVal;

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
            result += ConverterUtil.convertDigit(hundVal) + " hundred ";

            return result;
        }

        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }

        public bool IsMatch(int num)
        {
            hundVal = (num % 1000) / 100;
            return hundVal > 0;
        }

        public bool InsertAnd(int num)
        {
            return IsMatch(num) && num % 100 == 0 && num / 1000 != 0;
        }
    }
}
