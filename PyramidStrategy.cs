/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: PyramidStrategy.cs
 */

namespace Assi1
{
    internal class PyramidStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            float evaluation = 0.0f;
            IIterator iterator = list.CreateIterator();
            while(!iterator.IsDone())
            {
                HeavyObject heavyObject = iterator.CurrentItem();
                // Add the point by get the Area of the object at the bottom (index 0)
                // If the radius of the current object is smaller than the previous object, add the points to evaluation
                // Otherwise deduct the point by the radius of the current object
                if (iterator.CurrentIndex() == 0)
                    evaluation += heavyObject.Width * heavyObject.Length;
                if (iterator.CurrentIndex() > 0)
                    if (heavyObject.Width * heavyObject.Length < iterator.GetPrevious().Width * iterator.GetPrevious().Height)
                        evaluation -= iterator.GetPrevious().Width * iterator.GetPrevious().Height;
                    else
                        evaluation += heavyObject.Width * heavyObject.Height;
                iterator.Next();
            }
            return evaluation;
        }//EvaluateStack()
    }//End of Class
}//End of Namespace
