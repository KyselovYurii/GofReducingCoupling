using System;

namespace StockExchange.Task2
{
    public class Offer
    {
        public Offer(Guid playerId, DealType dealType, string stockName, int numberOfShares)
        {
            PlayerId = playerId;
            DealType = dealType;
            StockName = stockName;
            NumberOfShares = numberOfShares;
        }

        public Guid PlayerId { get; }

        public DealType DealType { get; }

        public string StockName { get; }

        public int NumberOfShares { get; }
    }
}
