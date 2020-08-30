using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.DBAccess
{
    public class AccountDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=KAUSHAL\\SQLEXPRESS;Initial Catalog=StockMarketDB;User ID=sa;Password=pass@word1");
        }
    }
}
