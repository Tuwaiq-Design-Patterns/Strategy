using System;
using System.Collections.Generic;

namespace StrategyDemo
{
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("ShellSort list ");
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0) {
                for (i = 0; i < list.Count; i++) {
                    j = i;
                    temp = list[i];
                    while ((j >= pos) && (list[j - pos] > temp)) {
                        list[j] = list[j - pos];
                        j = j - pos;
                    }  
                    list[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
            Console.WriteLine("ShellSorted list ");
        }
    }
}