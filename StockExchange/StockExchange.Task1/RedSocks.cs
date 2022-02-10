using System;

namespace StockExchange.Task1
{
    public class RedSocks : IStockPlayer
    {
        private readonly IStockMediator _mediator;

        public RedSocks(IStockMediator mediator)
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
