using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Client class
    /// </summary>
    public class ShoppingCart
    {
        readonly IDiscountService _discountService;
        readonly IShippingCostsService _shippingCostsService;
        int _orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total cost = " +
                $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage)}");
        }
    }
}
