namespace StockExchange.Task3
{
    public interface IStockPlayer
    {
        int SoldShares { get; }

        int BoughtShares { get; }

        bool SellOffer(string stockName, int numberOfShares);

        bool BuyOffer(string stockName, int numberOfShares);

        void Update(int sold, int bought);
    }
}
