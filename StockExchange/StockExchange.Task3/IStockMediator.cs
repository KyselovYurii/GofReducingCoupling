namespace StockExchange.Task3
{
    public interface IStockMediator
    {
        bool TryMakeDeal(IStockPlayer player, DealType dealType, string stockName, int numberOfShares);
    }
}
