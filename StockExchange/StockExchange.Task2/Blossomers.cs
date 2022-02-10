using System;

namespace StockExchange.Task2
{
    public class Blossomers : BaseStockPlayer
    {
        public Blossomers(IStockMediator mediator, Guid id)
            : base(mediator, id)
        {
        }
    }
}
