using System;

namespace StockExchange.Task1
{
    public class Blossomers : IStockPlayer
    {
        private readonly IStockMediator _mediator;

        public Blossomers(IStockMediator mediator) 
        {
            _mediator = mediator;
        }

        public bool SellOffer(string stockName, int numberOfShares)
        {
            return _mediator.TryMakeDeal(this, DealType.Sell, stockName, numberOfShares);
        }

        public bool BuyOffer(string stockName, int numberOfShares)
        {
            return _mediator.TryMakeDeal(this, DealType.Buy, stockName, numberOfShares);
        }
    }
}
