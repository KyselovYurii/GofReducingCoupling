namespace StockExchange.Task3
{
    public partial class StockMediator
    {
        public class Offer
        {
            public IStockPlayer Player { get; }
            public DealType DealType { get; }
            public string StockName { get; }
            public int NumberOfShares { get; }

            public Offer(DealType type, string stockName, int numberOfShares, IStockPlayer player)
            {
                DealType = type;
                StockName = stockName;
                NumberOfShares = numberOfShares;
                Player = player;
            }
        }
    }
}
