using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete Factory
    public class CanadaShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new CanadaDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new CanadaShippingCostsService();
        }
    }
}
