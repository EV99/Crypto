using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace EF6Crypto.Models
{
    class CoinContext : DbContext
    {
        public CoinContext(DbContextOptions options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Coin> Coins { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<CoinExchange> CoinExchanges { get; set; }
        //public DbSet<CoinPriceHistory> CoinHistory { get; set; }
        //public DbSet<CoinSentiment> CoinSentiments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoinExchange>().HasKey(k => new { k.CoinID, k.ExchangeID });

            modelBuilder.Entity<CoinExchange>()
                .HasOne(c => c.Coin)
                .WithMany(c => c.CoinExchanges)
                .HasForeignKey(c => c.ExchangeID);

            modelBuilder.Entity<CoinExchange>()
                .HasOne(c => c.Exchange)
                .WithMany(c => c.CoinExchanges)
                .HasForeignKey(c => c.CoinID);
        }
    }
}
