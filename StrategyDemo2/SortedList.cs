using System;
using System.Collections.Generic;
using StrategyDemo;

namespace StrategyDemo2
{
    public class SortedList
    {
        private List<int> list = new List<int>();
        private ISortStrategy _sortStrategy;
        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }
        public void Add(int num)
        {
            list.Add(num);
        }
        public void Sort()
        {
            _sortStrategy.Sort(list);
            // Iterate over list and display results
            foreach (int num in list)
            {
                Console.WriteLine(" " + num);
            }
            Console.WriteLine();
        }
    }
}