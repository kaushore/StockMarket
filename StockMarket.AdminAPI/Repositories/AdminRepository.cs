using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.DBAccess;

namespace StockMarket.AdminAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private AdminDBContext context;

        public AdminRepository(AdminDBContext context)
        {
            this.context = context;
        }
        public void AddStockExchange(StockExchange stockExchange)
        {
            context.Add(stockExchange);
            context.SaveChanges();
        }
        public void AddCompany(Company company)
        {
            context.Add(company);
            context.SaveChanges();
        }

        public void DeactivateCompany(string cid)
        {
            Company company = context.Companies.SingleOrDefault(c => c.CompanyCode == cid);
            company.Activate = false;
        }

        public void DeleteStockExchange(string sid)
        {
            StockExchange stockExchange = context.StockExchanges.SingleOrDefault(s => s.StockExchangeId == sid);
            context.StockExchanges.Remove(stockExchange);
            context.SaveChanges();
        }
    }
}
