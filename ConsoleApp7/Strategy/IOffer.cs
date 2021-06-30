using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Strategy
{
    public interface IOffer
    {
        string Name { get; }
        double GetDiscountPercentage();
    }
}
