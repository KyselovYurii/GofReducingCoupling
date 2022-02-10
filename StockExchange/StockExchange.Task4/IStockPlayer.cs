namespace StockExchange.Task4
{
    public interface IStockPlayer
    {
        int SoldShares { get; }

        int BoughtShares { get; }

        bool SellOffer(string stockName, int numberOfShares);

        bool BuyOffer(string stockName, int numberOfShares);
    }
}
