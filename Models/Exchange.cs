using System;
using System.Collections.Generic;
using System.Text;

namespace EF6Crypto.Models
{
    class Exchange
    {
        //public Exchange()
        //{
        //    this.Coin = new List<Coin>();
        //}

        public int ExchangeID { get; set; }
        public string ExchangeName { get; set; }

        public virtual ICollection<CoinExchange> CoinExchanges { get; set; }
    }

}
