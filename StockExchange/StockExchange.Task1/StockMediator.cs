using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockExchange.Task1
{
    public class StockMediator : IStockMediator
    {
        private class Offer
        {
            public Offer(IStockPlayer player, DealType dealType, string stockName, int numberOfShares)
            {
                StockPlayer = player;
                DealType = dealType;
                StockName = stockName;
                NumberOfShares = numberOfShares;
            }

            public IStockPlayer StockPlayer { get; }
            public DealType DealType { get; }
            public string StockName { get; }
            public int NumberOfShares { get; }
        }

        private readonly List<Offer> _offers = new List<Offer>();

        public bool TryMakeDeal(IStockPlayer stockPlayer, DealType dealType, string stockName, int numberOfShares)
        {
            var offer = _offers.FirstOrDefault(o => o.StockPlayer != stockPlayer && o.DealType != dealType && o.StockName == stockName && o.NumberOfShares == numberOfShares);

            if(offer != null)
            {
                return _offers.Remove(offer);
            }

            _offers.Add(new Offer(stockPlayer, dealType, stockName, numberOfShares));
            return false;
        }
    }

}
