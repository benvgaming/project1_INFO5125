using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1
{
    internal class HeavyObjectList:IAggregate
    {
        private List<HeavyObject> heavyObjects;
        public HeavyObjectList()
        {
            heavyObjects = new List<HeavyObject>();
        }

        public IIterator CreateIterator()
        {
            throw new NotImplementedException();
        }//CreateIterator

        public void Add(HeavyObject heavyObject)
        {
            heavyObjects.Add(heavyObject);
        }

        public void Print()
        {
            foreach (HeavyObject heavyObject in heavyObjects)
                heavyObject.Print();
        }
    }
}
