using System;

namespace StockExchange.Task2
{
    public class StockPlayersFactory
    {
        public Players CreatePlayers()
        {
            var mediator = new StockMediator();

            return new Players(new RedSocks(mediator, Guid.NewGuid()), new Blossomers(mediator, Guid.NewGuid()));
        }
    }
}
