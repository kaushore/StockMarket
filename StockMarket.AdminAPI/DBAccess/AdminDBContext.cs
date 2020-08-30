using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.DBAccess
{
    public class AdminDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockExchange> StockExchanges { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<PlannedIPO> PlannedIPOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=KAUSHAL\\SQLEXPRESS;Initial Catalog=StockMarketDB;User ID=sa;Password=pass@word1");
        }
    }
}
