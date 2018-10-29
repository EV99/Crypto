using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF6Crypto.Models
{
    class Coin
    {
        //public Coin()
        //{
        //    this.Exchange = new List<Exchange>();
        //}

        [Key]
        public int CoinID { get; set; }
        public string CoinName { get; set; }
        public string CoinTicker { get; set; }
        public float CoinPrice { get; set; }
        public string CoinDescription { get; set; }

        public virtual ICollection<CoinExchange> CoinExchanges { get; set; }
    }
}
