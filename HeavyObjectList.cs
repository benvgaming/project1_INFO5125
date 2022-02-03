/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: HeavyObjectList.cs
 */

using System.Collections.Generic;

namespace Assi1
{
    internal class HeavyObjectList:IAggregate
    {
        private List<HeavyObject> heavyObjects;
        public HeavyObjectList()
        {
            heavyObjects = new List<HeavyObject>();
        }//c'tor

        public IIterator CreateIterator()
        {
            return new HeavyObjectIterator(this);
        }//CreateIterator

        public void Add(HeavyObject heavyObject)
        {
            heavyObjects.Add(heavyObject);
        }//Add()
        
        public HeavyObject At(int index)
        {
            return heavyObjects[index];
        }//At()

        public HeavyObject First()
        {
            return heavyObjects[0];
        }//First()
        public void Print()
        {
            foreach (HeavyObject heavyObject in heavyObjects)
                heavyObject.Print();
        }//Print()
        public int Length()
        {
            return heavyObjects.Count;
        }//Length()
    }//End of class
}//End of Namespace
