namespace StockExchange.Task2
{
    public interface IStockMediator
    {
        bool TryMakeDeal(Offer offer);
    }
}
