using System;

namespace StockExchange.Task2
{
    public interface IStockPlayer
    {
        Guid Id { get; }

        bool SellOffer(string stockName, int numberOfShares);

        bool BuyOffer(string stockName, int numberOfShares);
    }
}
