using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal abstract class Wordable : IWordable
    {
        protected int priority;
        public int CompareTo(IWordable other)
        {
            return priority.CompareTo(other.GetPriority());
        }
        public abstract string cconvert();
        public int GetPriority()
        {
            return priority;
        }
        public abstract bool InsertAnd(int num);
        public abstract bool IsMatch(int num);

        public string convert(int num)
        {
            string result = string.Empty;
            if (InsertAnd(num))
            {
                result += "and ";
            }
            result += cconvert();

            return result;
        }
    }
}
