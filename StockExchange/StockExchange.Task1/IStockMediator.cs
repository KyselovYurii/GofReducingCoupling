using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Task1
{
    public interface IStockMediator
    {
        bool TryMakeDeal(IStockPlayer stockPlayer, DealType dealType, string stockName, int numberOfShares);
    }
}
