namespace StockExchange.Task1
{
    public interface IStockPlayer
    {
        bool SellOffer(string stockName, int numberOfShares);
        bool BuyOffer(string stockName, int numberOfShares);
    }
}