using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.DBAccess;

namespace StockMarket.AdminAPI.Repositories
{
    public interface IAdminRepository
    {
        void AddStockExchange(StockExchange stockExchange);
        void AddCompany(Company company);
        void DeactivateCompany(string cid);
        void DeleteStockExchange(string sid);
        void AddIPO(PlannedIPO ipo);
        void UpdateIPO(PlannedIPO ipo);
    }
}
