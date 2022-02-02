using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, StackingStrategy> stackingStrategies;
        public StackingStrategy GetFlyWeight(string key)
        {
            if (stackingStrategies.ContainsKey(key))
                return stackingStrategies[key];
            StackingStrategy strategy = new StackingStrategy();
            stackingStrategies.Add(key, strategy);

            return strategy;
        }
    }
}
