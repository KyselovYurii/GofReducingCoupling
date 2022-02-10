using System;

namespace StockExchange.Task2
{
    public abstract class BaseStockPlayer : IStockPlayer
    {
        private readonly IStockMediator _mediator;

        protected BaseStockPlayer(IStockMediator mediator, Guid guid)
        {
            _mediator = mediator;
            Id = guid;
        }

        public Guid Id { get; }

        public bool SellOffer(string stockName, int numberOfShares)
        {
            return _mediator.TryMakeDeal(new Offer(Id, DealType.Sell, stockName, numberOfShares));
        }

        public bool BuyOffer(string stockName, int numberOfShares)
        {
            return _mediator.TryMakeDeal(new Offer(Id, DealType.Buy, stockName, numberOfShares));
        }
    }
}
