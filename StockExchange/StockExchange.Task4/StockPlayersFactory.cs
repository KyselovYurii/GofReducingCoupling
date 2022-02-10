﻿namespace StockExchange.Task4
{
    public class StockPlayersFactory
    {
        public Players CreatePlayers()
        {
            var mediator = new StockMediator();

            return new Players(new RedSocks(mediator), new Blossomers(mediator));
        }
    }
}
