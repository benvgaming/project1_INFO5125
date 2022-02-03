/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: IIterator.cs
 */

namespace Assi1
{
    internal interface IIterator
    {
        HeavyObject First();
        void Next();
        bool IsDone();
        HeavyObject CurrentItem();
        int CurrentIndex();
        HeavyObject GetPrevious();
    }//End of interface
}//End of Namespace
