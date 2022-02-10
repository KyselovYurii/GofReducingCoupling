using System.Collections.Generic;
using System.Linq;

namespace StockExchange.Task2
{
    public class StockMediator : IStockMediator
    {
        private readonly List<Offer> _offers = new List<Offer>();

        public bool TryMakeDeal(Offer offer)
        {
            var existingOffer = _offers.FirstOrDefault(o => o.PlayerId != offer.PlayerId &&
                                                    o.DealType != offer.DealType &&
                                                    o.StockName == offer.StockName &&
                                                    o.NumberOfShares == offer.NumberOfShares);

            if (existingOffer != null)
            {
                _offers.Remove(existingOffer);
                return true;
            }

            _offers.Add(offer);
            return false;
        }
    }
}
