using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1
{
    internal interface IIterator
    {
        HeavyObject First();
        void Next();
        bool IsDone();
        HeavyObject CurrentItem();
    }
}
