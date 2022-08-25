namespace DiscountServiceFactory
{
    // Concrete Product
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }

        public override int DiscountPercentage
        {
            // each code returns the discount %, but a code is only valid once
            get => 15;
        }
    }
}