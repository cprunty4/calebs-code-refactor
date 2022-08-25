namespace DiscountServiceFactory
{

    // Creator
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
}