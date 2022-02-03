/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: FlyweightFactory.cs
 */
using System.Collections.Generic;
namespace Assi1
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, StackingStrategy> stackingStrategies;
        public FlyweightFactory()
        {
            stackingStrategies = new Dictionary<string, StackingStrategy>();
        }//c'tor

        public StackingStrategy GetFlyweight(string key)
        {
            if (stackingStrategies.ContainsKey(key))
                return stackingStrategies[key];
            StackingStrategy strategy = null;
            if (key == "pyramid")
                strategy = new PyramidStrategy();
            else if (key == "topple")
                strategy = new ToppleStrategy();
            else
                strategy = new BottomWeightStrategy();
            stackingStrategies.Add(key, strategy);
            return strategy;
        }//GetFlyweight()
    }//End of Class
}//End of Namespace
