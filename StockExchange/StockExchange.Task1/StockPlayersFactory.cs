namespace StockExchange.Task1
{
    public class StockPlayersFactory
    {
        public Players CreatePlayers()
        {
            var medaitor = new StockMediator();

            return new Players
            {
                RedSocks = new RedSocks(medaitor),
                Blossomers = new Blossomers(medaitor)
            };
        }
    }
}
