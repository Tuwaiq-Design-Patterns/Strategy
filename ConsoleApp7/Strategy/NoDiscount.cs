using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Strategy
{
    public class NoDiscount : IOffer
    {
        public string Name => nameof(NoDiscount);

        public double GetDiscountPercentage()
        {
            return 0;
        }
    }
}
