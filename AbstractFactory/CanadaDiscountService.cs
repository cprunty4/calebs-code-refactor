using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CanadaDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }
}
