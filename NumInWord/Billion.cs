using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    internal class Billion: Wordable
    {
        private readonly IComposable composable;
        private long billVal;

        public Billion()
        {
            priority = 7;
            composable = new Composable();
        }
        public override string convert()
        {
            return composable.convert(billVal) + "billion ";
        }

        public override bool IsMatch(long num)
        {
            billVal = (num % 1000000000000) / 1000000000;
            return billVal > 0;
        }

        public override bool InsertAnd(long num)
        {
            return IsMatch(num) && num % 1000000000 == 0 && num / 1000000000000 != 0 && billVal < 100;
        }
    }
}
