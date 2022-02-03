/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: HeavyObjectIterator.cs
 */

namespace Assi1
{
    internal class HeavyObjectIterator : IIterator
    {
        protected HeavyObjectList list;
        protected int index;
        public HeavyObjectIterator(HeavyObjectList list)
        {
            this.list = list;
            index = 0;
        }// c'tor

        public HeavyObject CurrentItem()
        {
            return list.At(index);
        }//CurrentItem()
        
        public int CurrentIndex()
        {
            return index;
        }//CurrentIndex()

        public HeavyObject First()
        {
            return list.First();
        }//First()

        public bool IsDone()
        {
            return index >= list.Length();
        }//IsDone()
        
        public HeavyObject GetPrevious()
        {
            if(index != 0)
                return list.At(index - 1);
            else
                return null;
        }//GetPrevious()

        public void Next()
        {
            index++;
        }//Next()
    }//End of class
}//End of namespace
