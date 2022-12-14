namespace DiscountServiceFactory
{
    // Concrete Creator
    public class CountryDiscountFactory : DiscountFactory
    {
        readonly string _countryIdentifier;

        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }
}