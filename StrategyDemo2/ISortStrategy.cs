using System.Collections.Generic;

namespace StrategyDemo
{
    public interface ISortStrategy
    {
        public void Sort(List<int> list);
    }
}