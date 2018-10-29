using System;
using System.Collections.Generic;
using System.Text;

namespace EF6Crypto.Models
{
    class CoinExchange
    {
        public int CoinID { get; set; }
        public int ExchangeID { get; set; }

        public Coin Coin { get; set; }
        public Exchange Exchange { get; set; }
    }
}
