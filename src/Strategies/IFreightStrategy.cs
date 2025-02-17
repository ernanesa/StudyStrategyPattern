namespace Study_Strategy_Pattern.Strategies
{
    public interface IFreightStrategy
    {
        decimal CalculateFreight(decimal weight);
    }
}
