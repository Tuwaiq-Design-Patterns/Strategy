using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Strategy
{
    public class QuarterDiscount : IOffer
    {
        public string Name => nameof(QuarterDiscount);

        public double GetDiscountPercentage()
        {
            return 0.25;
        }
    }
}
