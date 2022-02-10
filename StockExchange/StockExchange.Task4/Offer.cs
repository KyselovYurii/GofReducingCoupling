namespace StockExchange.Task4
{
    public class Offer
    {
        public Offer(IStockPlayer player, DealType dealType, string stockName, int numberOfShares)
        {
            Player = player;
            DealType = dealType;
            StockName = stockName;
            NumberOfShares = numberOfShares;
        }

        public IStockPlayer Player { get; }
        public DealType DealType { get; }
        public string StockName { get; }
        public int NumberOfShares { get; }
    }
}
