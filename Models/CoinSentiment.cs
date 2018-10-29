using System;
using System.Collections.Generic;
using System.Text;

namespace EF6Crypto.Models
{
    class CoinSentiment
    {
        public int CoinID { get; set; }
        public string Medium { get; set; }
        public float Sentiment { get; set; }
    }
}
