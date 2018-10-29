using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using EF6Crypto.Models;

namespace EF6Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbContextOptions = new CoinContext(GetOptions("Server=.\\SQLEXPRESS;Database=Crypto2;Trusted_Connection=True;"));
            using (var cc = DbContextOptions)
            {
                TestCreate(cc, "Bitcoin", "BTC", "Bitcoin", 6350, "CoinBase");

            }
        }

        public static void TestCreate(CoinContext cc, string CoinName, string CoinTicker, string CoinDescription, float CoinPrice,
                                      string ExchangeName)
        {
            var coin = new Coin()
                { CoinName = "Ethereum", CoinTicker = "ETH", CoinDescription = "Ethereum", CoinPrice = 202 };
            var exchange = new Exchange()
                { ExchangeName = "MtGox" };
            var coinExchange = new CoinExchange()
                { Coin = coin, Exchange = exchange };

            cc.Coins.Add(coin);
            cc.Exchanges.Add(exchange);
            cc.CoinExchanges.Add(coinExchange);
            cc.SaveChanges();
        }

        public static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
    }
}
