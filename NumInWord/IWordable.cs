using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInWord
{
    public interface IWordable : IComparable<IWordable>
    {
        string cconvert();

        int GetPriority();

        bool IsMatch(int num);

        bool InsertAnd(int num);
    }
}
