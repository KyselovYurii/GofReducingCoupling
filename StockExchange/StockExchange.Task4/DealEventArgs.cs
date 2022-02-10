namespace StockExchange.Task4
{
    public class DealEventArgs
    {
        public DealEventArgs(int bought, int sold)
        {
            Bought = bought;
            Sold = sold;
        }

        public int Bought { get; set; }
        public int Sold { get; set; }
    }
}
