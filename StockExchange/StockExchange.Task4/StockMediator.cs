using System;
using System.Collections.Generic;
using System.Linq;

namespace StockExchange.Task4
{
    public partial class StockMediator : IStockMediator
    {
        private readonly List<Offer> _offers = new List<Offer>();

        public event EventHandler<DealEventArgs> UpdateStatus;

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
                    UpdateStatus?.Invoke(existingOffer.Player, new DealEventArgs(numberOfShares, 0));
                    UpdateStatus?.Invoke(player, new DealEventArgs(0, numberOfShares));
                }
                else
                {
                    UpdateStatus?.Invoke(existingOffer.Player, new DealEventArgs(0, numberOfShares));
                    UpdateStatus?.Invoke(player, new DealEventArgs(numberOfShares, 0));
                }

                return _offers.Remove(existingOffer);
            }

            _offers.Add(new Offer(player, dealType, stockName, numberOfShares));

            return false;
        }
    }
}
