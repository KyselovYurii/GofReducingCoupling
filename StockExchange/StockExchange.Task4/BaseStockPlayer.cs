namespace StockExchange.Task4
{
    public abstract class BaseStockPlayer : IStockPlayer
    {
        private readonly IStockMediator _mediator;

        protected BaseStockPlayer(IStockMediator mediator)
        {
            _mediator = mediator;
            _mediator.UpdateStatus += MediatorUpdateStatus;
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

        private void MediatorUpdateStatus(object sender, DealEventArgs e)
        {
            if (sender != this)
            {
                return;
            }

            BoughtShares += e.Bought;
            SoldShares += e.Sold;
        }
    }
}
