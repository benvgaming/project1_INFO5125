/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: BottomWeightStrategy.cs
 */
namespace Assi1
{
    internal class BottomWeightStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            float evaluation = 0.0f;
            IIterator iterator = list.CreateIterator();
            while(!iterator.IsDone())
            {
                // The bigger the mass at the bottom, the higher the score
                // The object at the bottom (index 0) will have the full score
                // Divide the mass by their index + 1 (to avoid divide by 0) so when it's higher the point will be lower               
                HeavyObject heavyObject = iterator.CurrentItem();
                    evaluation += heavyObject.Mass/ ((float) iterator.CurrentIndex() + 1.0f);
                iterator.Next();
            }
            return evaluation;
        }//EvaluateStack()
    }//End of class
}//End of Namespace
