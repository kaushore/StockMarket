using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Repositories;

namespace StockMarket.AdminAPI.Services
{
    public class AdminService : IAdminService
    {
        private IAdminRepository adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        public void AddStockExchange(StockExchange stockExchange)
        {
            adminRepository.AddStockExchange(stockExchange);
        }
        public void AddCompany(Company company)
        {
            adminRepository.AddCompany(company);
        }

        public void DeactivateCompany(string cid)
        {
            adminRepository.DeactivateCompany(cid);
        }

        public void DeleteStockExchange(string sid)
        {
            adminRepository.DeleteStockExchange(sid);
        }

        public void AddIPO(PlannedIPO ipo)
        {
            adminRepository.AddIPO(ipo);
        }

        public void UpdateIPO(PlannedIPO ipo)
        {
            adminRepository.UpdateIPO(ipo);
        }
    }
}
