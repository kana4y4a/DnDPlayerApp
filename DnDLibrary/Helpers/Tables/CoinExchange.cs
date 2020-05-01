namespace DnDLibrary.Helpers.Tables
{
    using DnDLibrary.Models.Emuns;

    public static class CoinExchange
    {
        public static readonly CoinExchangeItem[] Table = {
            new CoinExchangeItem { CoinType = CoinsType.Copper, Coef_cp = 1.0f, Coef_sp = 0.1f, Coef_ep = 0.02f, Coef_gp = 0.01f, Coef_pp = 0.001f },
            new CoinExchangeItem { CoinType = CoinsType.Silver, Coef_cp = 10.0f, Coef_sp = 1.0f, Coef_ep = 0.2f, Coef_gp = 0.1f, Coef_pp = 0.01f },
            new CoinExchangeItem { CoinType = CoinsType.Electrum, Coef_cp = 50.0f, Coef_sp = 5.0f, Coef_ep = 1.0f, Coef_gp = 0.5f, Coef_pp = 0.05f },
            new CoinExchangeItem { CoinType = CoinsType.Gold, Coef_cp = 100.0f, Coef_sp = 10.0f, Coef_ep = 2.0f, Coef_gp = 1.0f, Coef_pp = 0.1f },
            new CoinExchangeItem { CoinType = CoinsType.Platinum, Coef_cp = 1000.0f, Coef_sp = 100.0f, Coef_ep = 20.0f, Coef_gp = 10.0f, Coef_pp = 1.0f }
        };
    };

    public class CoinExchangeItem
    {
        public CoinsType CoinType { get; internal set; }
        public float Coef_cp { get; internal set; }
        public float Coef_sp { get; internal set; }
        public float Coef_ep { get; internal set; }
        public float Coef_gp { get; internal set; }
        public float Coef_pp { get; internal set; }


        internal CoinExchangeItem()
        {
        }
    };

}