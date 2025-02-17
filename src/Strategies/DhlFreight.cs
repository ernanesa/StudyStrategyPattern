namespace Study_Strategy_Pattern.Strategies
{
    public class DhlFreight : IFreightStrategy
    {
        public decimal CalculateFreight(decimal weight) => weight * 0.6m + 5m;
    }
}
