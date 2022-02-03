/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: ToppleStrategy.cs
 */

namespace Assi1
{
    internal class ToppleStrategy : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList list)
        {
            float evaluation = 0.0f;
            IIterator iterator = list.CreateIterator();

            while(!iterator.IsDone())
            {
                HeavyObject heavyObject = iterator.CurrentItem();
                // First add the mass divide by the length of the list minus by the index of the object (the lower the index the lower the score since it got divided)
                // so the higher the index, the higher the score
                // if the mass of the previous object is higher than the current object, we deduct the point since it won't cause the stack to fall over
                if (iterator.CurrentIndex() > 0)
                    if (heavyObject.Mass < iterator.GetPrevious().Mass)
                        evaluation += iterator.GetPrevious().Mass / (list.Length() - iterator.CurrentIndex() + 1);
                    else
                        evaluation -= heavyObject.Mass / (list.Length() - iterator.CurrentIndex() + 1);
                else
                    evaluation += heavyObject.Mass /(list.Length() - iterator.CurrentIndex());
                iterator.Next();
            }
            return evaluation;
        }//EvaluateStack()
    }//End of Class
}//End of Namespace
