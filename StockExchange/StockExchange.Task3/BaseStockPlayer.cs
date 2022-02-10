namespace StockExchange.Task3
{
    public abstract class BaseStockPlayer : IStockPlayer
    {
        private readonly IStockMediator _mediator;

        protected BaseStockPlayer(IStockMediator mediator)
        {
            _mediator = mediator;
        }

        public int SoldShares { get; private set; }

        public int BoughtShares { get; private set; }

        public bool SellOffer(string stockName, int numberOfShares)
        {
            return _mediator.TryMakeDeal(this, DealType.Sell, stockName, numberOfShares);
        }

        public bool BuyOffer(string stockName, int numberOfShares)
        {
            return _mediator.TryMakeDeal(this, DealType.Buy, stockName, numberOfShares);
        }

        public void Update(int sold, int bought)
        {
            SoldShares += sold;
            BoughtShares += bought;
        }
    }
}
