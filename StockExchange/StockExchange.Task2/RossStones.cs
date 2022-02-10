using System;

namespace StockExchange.Task2
{
    public class RossStones : BaseStockPlayer
    {
        public RossStones(IStockMediator mediator, Guid id)
            : base(mediator, id)
        {
        }
    }
}
