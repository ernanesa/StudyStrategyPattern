namespace Study_Strategy_Pattern.Strategies
{
    public class CorreiosFreight : IFreightStrategy
    {
        public decimal CalculateFreight(decimal weight) => weight * 0.5m;
    }
}
