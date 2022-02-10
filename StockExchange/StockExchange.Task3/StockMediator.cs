using System.Collections.Generic;
using System.Linq;

namespace StockExchange.Task3
{
    public partial class StockMediator : IStockMediator
    {
        private readonly List<Offer> _offers = new List<Offer>();

        public bool TryMakeDeal(IStockPlayer player, DealType dealType, string stockName, int numberOfShares)
        {
            var existingOffer = _offers.FirstOrDefault(o => o.Player != player &&
                                                            o.DealType != dealType &&
                                                            o.StockName == stockName &&
                                                            o.NumberOfShares == numberOfShares);

            if (existingOffer != null)
            {

                if (existingOffer.DealType == DealType.Buy)
                {
                    existingOffer.Player.Update(0, numberOfShares);
                    player.Update(numberOfShares, 0);

                }
                else
                {
                    existingOffer.Player.Update(numberOfShares, 0);
                    player.Update(0, numberOfShares);
                }

                return _offers.Remove(existingOffer);
            }

            _offers.Add(new Offer(dealType, stockName, numberOfShares, player));

            return false;
        }
    }
}
