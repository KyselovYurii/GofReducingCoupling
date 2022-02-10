using System;

namespace StockExchange.Task4
{
    public interface IStockMediator
    {
        event EventHandler<DealEventArgs> UpdateStatus;

        bool TryMakeDeal(IStockPlayer player, DealType dealType, string stockName, int numberOfShares);
    }
}
