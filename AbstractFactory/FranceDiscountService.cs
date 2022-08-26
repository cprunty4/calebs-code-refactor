﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }
}
