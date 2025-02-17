using Study_Strategy_Pattern.Strategies;

namespace Study_Strategy_Pattern.Context
{
    public class FreightCalculator
    {
        private readonly IFreightStrategy _freightStrategy;

        public FreightCalculator(IFreightStrategy freightStrategy)
        {
            _freightStrategy = freightStrategy;
        }

        public decimal Calculate(decimal weight) => _freightStrategy.CalculateFreight(weight);
    }
}
