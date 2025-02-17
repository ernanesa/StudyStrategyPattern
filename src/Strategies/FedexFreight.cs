namespace Study_Strategy_Pattern.Strategies
{
    public class FedexFreight : IFreightStrategy
    {
        public decimal CalculateFreight(decimal weight) => weight * 0.7m + 10m;
    }
}
