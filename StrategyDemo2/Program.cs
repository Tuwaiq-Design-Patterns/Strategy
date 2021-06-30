using System;
using System.Collections.Generic;
using StrategyDemo;

namespace StrategyDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList sortedList = new SortedList();

            sortedList.SetSortStrategy(new ShellSort());
            
            sortedList.Add(4);
            sortedList.Add(3);
            sortedList.Add(1);
            sortedList.Add(9);
            sortedList.Add(7);
            sortedList.Add(5);
            
            sortedList.Sort();
        }
    }
}