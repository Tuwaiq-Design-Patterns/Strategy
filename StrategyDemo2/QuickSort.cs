using System;
using System.Collections.Generic;

namespace StrategyDemo
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list ");
        }
    }
}