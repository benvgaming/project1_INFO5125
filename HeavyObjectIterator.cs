using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1
{
    internal class HeavyObjectIterator
    {
        protected HeavyObjectList list;
        protected int index;
        public HeavyObjectIterator(HeavyObjectList list)
        {
            this.list = list;
            index = 0;
        }
    }
}
