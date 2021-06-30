using System;
using System.Collections.Generic;
using StrategyDemo;

namespace StrategyDemo2
{
    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("BubbleSort list ");
            int temp;
            for (int p = 0; p <= list.Count - 2; p++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                } 
            }
        }
    }
}