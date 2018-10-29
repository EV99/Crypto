using System;
using System.Collections.Generic;
using System.Text;

namespace EF6Crypto.Models
{
    class CoinPriceHistory
    {
        public int CoinID { get; set; }
        public DateTime DateTime { get; set; }
        public float Price { get; set; }

        public virtual Coin Coin { get; set; }
    }
}
